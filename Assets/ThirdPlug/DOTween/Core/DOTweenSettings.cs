﻿// Author: Daniele Giardini - http://www.demigiant.com
// Created: 2015/02/05 10:28

using System;
using DG.Tweening.Core.Enums;
using UnityEngine;

#pragma warning disable 1591
namespace DG.Tweening.Core
{
    public class DOTweenSettings : ScriptableObject
    {
        public const string AssetName = "DOTweenSettings";
        public const string AssetFullFilename = AssetName + ".asset";

        public bool useSafeMode = true;
        public SafeModeOptions safeModeOptions = new SafeModeOptions();
        public float timeScale = 1;
        public bool useSmoothDeltaTime;
        public float maxSmoothUnscaledTime = 0.15f; // Used if useSmoothDeltaTime is TRUE
        public RewindCallbackMode rewindCallbackMode = RewindCallbackMode.FireIfPositionChanged;
        public bool showUnityEditorReport;
        public LogBehaviour logBehaviour = LogBehaviour.Default;
        public bool drawGizmos = true;
        public bool defaultRecyclable;
        public AutoPlay defaultAutoPlay = AutoPlay.All;
        public UpdateType defaultUpdateType;
        public bool defaultTimeScaleIndependent;
        public Ease defaultEaseType = Ease.OutQuad;
        public float defaultEaseOvershootOrAmplitude = 1.70158f;
        public float defaultEasePeriod = 0;
        public bool defaultAutoKill = true;
        public LoopType defaultLoopType = LoopType.Restart;

        // Pro-only - accessed via DOTweenAnimationInspector
        public bool showPreviewPanel = true;

        // Editor-only
        public enum SettingsLocation
        {
            AssetsDirectory,
            DOTweenDirectory,
            DemigiantDirectory
        }
        public SettingsLocation storeSettingsLocation = SettingsLocation.AssetsDirectory;
        public ModulesSetup modules = new ModulesSetup();

        // Editor-Only ► DOTween Inspector
        public bool showPlayingTweens, showPausedTweens;

        // █████████████████████████████████████████████████████████████████████████████████████████████████████████████████████
        // ███ INTERNAL CLASSES ████████████████████████████████████████████████████████████████████████████████████████████████
        // █████████████████████████████████████████████████████████████████████████████████████████████████████████████████████

        [Serializable]
        public class SafeModeOptions
        {
            public NestedTweenFailureBehaviour nestedTweenFailureBehaviour = NestedTweenFailureBehaviour.TryToPreserveSequence;
        }

        [Serializable]
        public class ModulesSetup // Editor-only
        {
            public bool showPanel;

            public bool audioEnabled = true;
            public bool physicsEnabled = true;
            public bool physics2DEnabled = true;
            public bool spriteEnabled = true;
            public bool uiEnabled = true;
            public bool textMeshProEnabled;
            public bool tk2DEnabled;
        }
    }
}