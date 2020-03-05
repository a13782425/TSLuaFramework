using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TSLuaFramework.Module
{
    public abstract class BaseModule<T> : IModule where T : BaseModule<T>, new()
    {
        private static T _instance = null;

        public static T Instance => _instance;

        private GameObject _gameObject;
        public GameObject gameObject => _gameObject;

        public Transform transform => _gameObject?.transform;

        private Dictionary<int, Coroutine> _coroutineDic;

        private ILogger _logger = null;
        protected ILogger Log
        {
            get
            {
                if (_logger == null)
                {
                    _logger = LogModule.Instance.GetLogger(_instance.GetType().Name);
                }
                return _logger;
            }
        }

        public BaseModule()
        {
            _gameObject = new UnityEngine.GameObject(this.GetType().Name);
            _gameObject.transform.SetParent(GameApp.Instance.transform);
            _coroutineDic = new Dictionary<int, Coroutine>();
            _instance = this as T;
            if (_instance == null)
            {
                Debug.LogError($"ModuleType:{this.GetType().Name},=== T Type:{typeof(T).Name}");
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public virtual void Init()
        {

        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="deltaTime">帧时间</param>
        public virtual void Update(float deltaTime)
        {

        }
        /// <summary>
        /// 释放
        /// </summary>
        public virtual void Freed()
        {

        }

        /// <summary>
        /// 启动协程
        /// </summary>
        /// <param name="routine"></param>
        /// <returns></returns>
        protected Coroutine StartCoroutine(IEnumerator routine)
        {
            Coroutine coroutine = GameApp.Instance.StartCoroutine(routine);
            _coroutineDic.Add(coroutine.GetHashCode(), coroutine);
            return coroutine;
        }
        /// <summary>
        /// 停止协程
        /// </summary>
        /// <param name="coroutine"></param>
        public void StopCoroutine(Coroutine coroutine)
        {
            GameApp.Instance.StopCoroutine(coroutine);
            int hashCode = coroutine.GetHashCode();
            if (_coroutineDic.ContainsKey(hashCode))
            {
                _coroutineDic.Remove(hashCode);
            }
        }

        /// <summary>
        /// 停止协程
        /// </summary>
        public void StopAllCoroutines()
        {
            foreach (var item in _coroutineDic)
            {
                GameApp.Instance.StopCoroutine(item.Value);
            }
            _coroutineDic.Clear();
        }
    }
}