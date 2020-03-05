#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua
{
    public partial class ObjectTranslator
    {
        public void __RegisterUnityEngineNetworkingUnityWebRequest(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.Networking.UnityWebRequest);
			Utils.BeginObjectRegister(type, L, this, 0, 7, 22, 12);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", UnityEngineNetworkingUnityWebRequest_m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendWebRequest", UnityEngineNetworkingUnityWebRequest_m_SendWebRequest);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Abort", UnityEngineNetworkingUnityWebRequest_m_Abort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetRequestHeader", UnityEngineNetworkingUnityWebRequest_m_GetRequestHeader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetRequestHeader", UnityEngineNetworkingUnityWebRequest_m_SetRequestHeader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResponseHeader", UnityEngineNetworkingUnityWebRequest_m_GetResponseHeader);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetResponseHeaders", UnityEngineNetworkingUnityWebRequest_m_GetResponseHeaders);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "disposeCertificateHandlerOnDispose", UnityEngineNetworkingUnityWebRequest_g_get_disposeCertificateHandlerOnDispose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disposeDownloadHandlerOnDispose", UnityEngineNetworkingUnityWebRequest_g_get_disposeDownloadHandlerOnDispose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "disposeUploadHandlerOnDispose", UnityEngineNetworkingUnityWebRequest_g_get_disposeUploadHandlerOnDispose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "method", UnityEngineNetworkingUnityWebRequest_g_get_method);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "error", UnityEngineNetworkingUnityWebRequest_g_get_error);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useHttpContinue", UnityEngineNetworkingUnityWebRequest_g_get_useHttpContinue);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "url", UnityEngineNetworkingUnityWebRequest_g_get_url);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uri", UnityEngineNetworkingUnityWebRequest_g_get_uri);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "responseCode", UnityEngineNetworkingUnityWebRequest_g_get_responseCode);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uploadProgress", UnityEngineNetworkingUnityWebRequest_g_get_uploadProgress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isModifiable", UnityEngineNetworkingUnityWebRequest_g_get_isModifiable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isDone", UnityEngineNetworkingUnityWebRequest_g_get_isDone);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isNetworkError", UnityEngineNetworkingUnityWebRequest_g_get_isNetworkError);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isHttpError", UnityEngineNetworkingUnityWebRequest_g_get_isHttpError);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "downloadProgress", UnityEngineNetworkingUnityWebRequest_g_get_downloadProgress);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uploadedBytes", UnityEngineNetworkingUnityWebRequest_g_get_uploadedBytes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "downloadedBytes", UnityEngineNetworkingUnityWebRequest_g_get_downloadedBytes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "redirectLimit", UnityEngineNetworkingUnityWebRequest_g_get_redirectLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "uploadHandler", UnityEngineNetworkingUnityWebRequest_g_get_uploadHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "downloadHandler", UnityEngineNetworkingUnityWebRequest_g_get_downloadHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "certificateHandler", UnityEngineNetworkingUnityWebRequest_g_get_certificateHandler);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "timeout", UnityEngineNetworkingUnityWebRequest_g_get_timeout);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "disposeCertificateHandlerOnDispose", UnityEngineNetworkingUnityWebRequest_s_set_disposeCertificateHandlerOnDispose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disposeDownloadHandlerOnDispose", UnityEngineNetworkingUnityWebRequest_s_set_disposeDownloadHandlerOnDispose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "disposeUploadHandlerOnDispose", UnityEngineNetworkingUnityWebRequest_s_set_disposeUploadHandlerOnDispose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "method", UnityEngineNetworkingUnityWebRequest_s_set_method);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useHttpContinue", UnityEngineNetworkingUnityWebRequest_s_set_useHttpContinue);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "url", UnityEngineNetworkingUnityWebRequest_s_set_url);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uri", UnityEngineNetworkingUnityWebRequest_s_set_uri);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "redirectLimit", UnityEngineNetworkingUnityWebRequest_s_set_redirectLimit);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "uploadHandler", UnityEngineNetworkingUnityWebRequest_s_set_uploadHandler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "downloadHandler", UnityEngineNetworkingUnityWebRequest_s_set_downloadHandler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "certificateHandler", UnityEngineNetworkingUnityWebRequest_s_set_certificateHandler);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "timeout", UnityEngineNetworkingUnityWebRequest_s_set_timeout);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineNetworkingUnityWebRequest, 18, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "ClearCookieCache", UnityEngineNetworkingUnityWebRequest_m_ClearCookieCache_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Get", UnityEngineNetworkingUnityWebRequest_m_Get_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Delete", UnityEngineNetworkingUnityWebRequest_m_Delete_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Head", UnityEngineNetworkingUnityWebRequest_m_Head_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Put", UnityEngineNetworkingUnityWebRequest_m_Put_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Post", UnityEngineNetworkingUnityWebRequest_m_Post_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EscapeURL", UnityEngineNetworkingUnityWebRequest_m_EscapeURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnEscapeURL", UnityEngineNetworkingUnityWebRequest_m_UnEscapeURL_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SerializeFormSections", UnityEngineNetworkingUnityWebRequest_m_SerializeFormSections_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GenerateBoundary", UnityEngineNetworkingUnityWebRequest_m_GenerateBoundary_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SerializeSimpleForm", UnityEngineNetworkingUnityWebRequest_m_SerializeSimpleForm_xlua_st_);
            
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kHttpVerbGET", UnityEngine.Networking.UnityWebRequest.kHttpVerbGET);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kHttpVerbHEAD", UnityEngine.Networking.UnityWebRequest.kHttpVerbHEAD);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kHttpVerbPOST", UnityEngine.Networking.UnityWebRequest.kHttpVerbPOST);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kHttpVerbPUT", UnityEngine.Networking.UnityWebRequest.kHttpVerbPUT);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kHttpVerbCREATE", UnityEngine.Networking.UnityWebRequest.kHttpVerbCREATE);
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "kHttpVerbDELETE", UnityEngine.Networking.UnityWebRequest.kHttpVerbDELETE);
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineNetworkingUnityWebRequest(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 1)
			{
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest();
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
			{
				string _url = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest(_url);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 2 && translator.Assignable<System.Uri>(L, 2))
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 2, typeof(System.Uri));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest(_uri);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
			{
				string _url = LuaAPI.lua_tostring(L, 2);
				string _method = LuaAPI.lua_tostring(L, 3);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest(_url, _method);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && translator.Assignable<System.Uri>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING))
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 2, typeof(System.Uri));
				string _method = LuaAPI.lua_tostring(L, 3);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest(_uri, _method);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 5 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.Networking.DownloadHandler>(L, 4) && translator.Assignable<UnityEngine.Networking.UploadHandler>(L, 5))
			{
				string _url = LuaAPI.lua_tostring(L, 2);
				string _method = LuaAPI.lua_tostring(L, 3);
				UnityEngine.Networking.DownloadHandler _downloadHandler = (UnityEngine.Networking.DownloadHandler)translator.GetObject(L, 4, typeof(UnityEngine.Networking.DownloadHandler));
				UnityEngine.Networking.UploadHandler _uploadHandler = (UnityEngine.Networking.UploadHandler)translator.GetObject(L, 5, typeof(UnityEngine.Networking.UploadHandler));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest(_url, _method, _downloadHandler, _uploadHandler);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 5 && translator.Assignable<System.Uri>(L, 2) && (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING) && translator.Assignable<UnityEngine.Networking.DownloadHandler>(L, 4) && translator.Assignable<UnityEngine.Networking.UploadHandler>(L, 5))
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 2, typeof(System.Uri));
				string _method = LuaAPI.lua_tostring(L, 3);
				UnityEngine.Networking.DownloadHandler _downloadHandler = (UnityEngine.Networking.DownloadHandler)translator.GetObject(L, 4, typeof(UnityEngine.Networking.DownloadHandler));
				UnityEngine.Networking.UploadHandler _uploadHandler = (UnityEngine.Networking.UploadHandler)translator.GetObject(L, 5, typeof(UnityEngine.Networking.UploadHandler));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = new UnityEngine.Networking.UnityWebRequest(_uri, _method, _downloadHandler, _uploadHandler);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest constructor!");
            
        }
        
		
        
		
        
        
        
        
        int UnityEngineNetworkingUnityWebRequest_m_ClearCookieCache_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 0) 
			{
				
				UnityEngine.Networking.UnityWebRequest.ClearCookieCache(  );
				
				
				
				return 0;
			}
			if(gen_param_count == 1&& translator.Assignable<System.Uri>(L, 1)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				
				UnityEngine.Networking.UnityWebRequest.ClearCookieCache( _uri );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.ClearCookieCache!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Dispose(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Dispose(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_SendWebRequest(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				
				UnityEngine.Networking.UnityWebRequestAsyncOperation gen_ret = gen_to_be_invoked.SendWebRequest(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Abort(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Abort(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_GetRequestHeader(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				string _name = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.GetRequestHeader( _name );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_SetRequestHeader(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				string _name = LuaAPI.lua_tostring(L, 2);
				string _value = LuaAPI.lua_tostring(L, 3);
				
				gen_to_be_invoked.SetRequestHeader( _name, _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_GetResponseHeader(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				string _name = LuaAPI.lua_tostring(L, 2);
				
				string gen_ret = gen_to_be_invoked.GetResponseHeader( _name );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_GetResponseHeaders(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            
			
			{
				
				System.Collections.Generic.Dictionary<string, string> gen_ret = gen_to_be_invoked.GetResponseHeaders(  );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Get_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Get( _uri );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& translator.Assignable<System.Uri>(L, 1)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Get( _uri );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.Get!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Delete_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Delete( _uri );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& translator.Assignable<System.Uri>(L, 1)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Delete( _uri );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.Delete!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Head_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Head( _uri );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 1&& translator.Assignable<System.Uri>(L, 1)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Head( _uri );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.Head!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Put_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				byte[] _bodyData = LuaAPI.lua_tobytes(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Put( _uri, _bodyData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Uri>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				byte[] _bodyData = LuaAPI.lua_tobytes(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Put( _uri, _bodyData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				string _bodyData = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Put( _uri, _bodyData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Uri>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				string _bodyData = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Put( _uri, _bodyData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.Put!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_Post_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				string _postData = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _postData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Uri>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				string _postData = LuaAPI.lua_tostring(L, 2);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _postData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.WWWForm>(L, 2)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				UnityEngine.WWWForm _formData = (UnityEngine.WWWForm)translator.GetObject(L, 2, typeof(UnityEngine.WWWForm));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _formData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Uri>(L, 1)&& translator.Assignable<UnityEngine.WWWForm>(L, 2)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				UnityEngine.WWWForm _formData = (UnityEngine.WWWForm)translator.GetObject(L, 2, typeof(UnityEngine.WWWForm));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _formData );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>>(L, 2)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> _multipartFormSections = (System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _multipartFormSections );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Uri>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>>(L, 2)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> _multipartFormSections = (System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _multipartFormSections );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				System.Collections.Generic.Dictionary<string, string> _formFields = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _formFields );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& translator.Assignable<System.Uri>(L, 1)&& translator.Assignable<System.Collections.Generic.Dictionary<string, string>>(L, 2)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				System.Collections.Generic.Dictionary<string, string> _formFields = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.Dictionary<string, string>));
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _formFields );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
			{
				string _uri = LuaAPI.lua_tostring(L, 1);
				System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> _multipartFormSections = (System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>));
				byte[] _boundary = LuaAPI.lua_tobytes(L, 3);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _multipartFormSections, _boundary );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 3&& translator.Assignable<System.Uri>(L, 1)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>>(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
			{
				System.Uri _uri = (System.Uri)translator.GetObject(L, 1, typeof(System.Uri));
				System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> _multipartFormSections = (System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>));
				byte[] _boundary = LuaAPI.lua_tobytes(L, 3);
				
				UnityEngine.Networking.UnityWebRequest gen_ret = UnityEngine.Networking.UnityWebRequest.Post( _uri, _multipartFormSections, _boundary );
				translator.Push(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.Post!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_EscapeURL_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _s = LuaAPI.lua_tostring(L, 1);
				
				string gen_ret = UnityEngine.Networking.UnityWebRequest.EscapeURL( _s );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Text.Encoding>(L, 2)) 
			{
				string _s = LuaAPI.lua_tostring(L, 1);
				System.Text.Encoding _e = (System.Text.Encoding)translator.GetObject(L, 2, typeof(System.Text.Encoding));
				
				string gen_ret = UnityEngine.Networking.UnityWebRequest.EscapeURL( _s, _e );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.EscapeURL!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_UnEscapeURL_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
			{
				string _s = LuaAPI.lua_tostring(L, 1);
				
				string gen_ret = UnityEngine.Networking.UnityWebRequest.UnEscapeURL( _s );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Text.Encoding>(L, 2)) 
			{
				string _s = LuaAPI.lua_tostring(L, 1);
				System.Text.Encoding _e = (System.Text.Encoding)translator.GetObject(L, 2, typeof(System.Text.Encoding));
				
				string gen_ret = UnityEngine.Networking.UnityWebRequest.UnEscapeURL( _s, _e );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Networking.UnityWebRequest.UnEscapeURL!");
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_SerializeFormSections_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection> _multipartFormSections = (System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>)translator.GetObject(L, 1, typeof(System.Collections.Generic.List<UnityEngine.Networking.IMultipartFormSection>));
				byte[] _boundary = LuaAPI.lua_tobytes(L, 2);
				
				byte[] gen_ret = UnityEngine.Networking.UnityWebRequest.SerializeFormSections( _multipartFormSections, _boundary );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_GenerateBoundary_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            
			
			{
				
				byte[] gen_ret = UnityEngine.Networking.UnityWebRequest.GenerateBoundary(  );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int UnityEngineNetworkingUnityWebRequest_m_SerializeSimpleForm_xlua_st_(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
			
			{
				System.Collections.Generic.Dictionary<string, string> _formFields = (System.Collections.Generic.Dictionary<string, string>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<string, string>));
				
				byte[] gen_ret = UnityEngine.Networking.UnityWebRequest.SerializeSimpleForm( _formFields );
				LuaAPI.lua_pushstring(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        
        
        
        int UnityEngineNetworkingUnityWebRequest_g_get_disposeCertificateHandlerOnDispose(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.disposeCertificateHandlerOnDispose);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_disposeDownloadHandlerOnDispose(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.disposeDownloadHandlerOnDispose);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_disposeUploadHandlerOnDispose(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.disposeUploadHandlerOnDispose);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_method(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.method);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_error(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.error);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_useHttpContinue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.useHttpContinue);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_url(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushstring(L, gen_to_be_invoked.url);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_uri(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.uri);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_responseCode(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushint64(L, gen_to_be_invoked.responseCode);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_uploadProgress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.uploadProgress);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_isModifiable(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isModifiable);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_isDone(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isDone);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_isNetworkError(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isNetworkError);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_isHttpError(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isHttpError);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_downloadProgress(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushnumber(L, gen_to_be_invoked.downloadProgress);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_uploadedBytes(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushuint64(L, gen_to_be_invoked.uploadedBytes);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_downloadedBytes(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.lua_pushuint64(L, gen_to_be_invoked.downloadedBytes);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_redirectLimit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.redirectLimit);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_uploadHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.uploadHandler);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_downloadHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.downloadHandler);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_certificateHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.certificateHandler);
            return 1;
        }
        
        int UnityEngineNetworkingUnityWebRequest_g_get_timeout(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.timeout);
            return 1;
        }
        
        
        
        int UnityEngineNetworkingUnityWebRequest_s_set_disposeCertificateHandlerOnDispose(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.disposeCertificateHandlerOnDispose = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_disposeDownloadHandlerOnDispose(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.disposeDownloadHandlerOnDispose = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_disposeUploadHandlerOnDispose(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.disposeUploadHandlerOnDispose = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_method(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.method = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_useHttpContinue(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.useHttpContinue = LuaAPI.lua_toboolean(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_url(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.url = LuaAPI.lua_tostring(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_uri(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.uri = (System.Uri)translator.GetObject(L, 2, typeof(System.Uri));
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_redirectLimit(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.redirectLimit = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_uploadHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.uploadHandler = (UnityEngine.Networking.UploadHandler)translator.GetObject(L, 2, typeof(UnityEngine.Networking.UploadHandler));
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_downloadHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.downloadHandler = (UnityEngine.Networking.DownloadHandler)translator.GetObject(L, 2, typeof(UnityEngine.Networking.DownloadHandler));
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_certificateHandler(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.certificateHandler = (UnityEngine.Networking.CertificateHandler)translator.GetObject(L, 2, typeof(UnityEngine.Networking.CertificateHandler));
            
            return 0;
        }
        
        int UnityEngineNetworkingUnityWebRequest_s_set_timeout(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.Networking.UnityWebRequest gen_to_be_invoked = (UnityEngine.Networking.UnityWebRequest)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.timeout = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
