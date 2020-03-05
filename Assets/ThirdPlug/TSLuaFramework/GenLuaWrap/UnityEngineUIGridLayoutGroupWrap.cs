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
        public void __RegisterUnityEngineUIGridLayoutGroup(RealStatePtr L) 
        {
		    System.Type type = typeof(UnityEngine.UI.GridLayoutGroup);
			Utils.BeginObjectRegister(type, L, this, 0, 4, 6, 6);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputHorizontal", UnityEngineUIGridLayoutGroup_m_CalculateLayoutInputHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CalculateLayoutInputVertical", UnityEngineUIGridLayoutGroup_m_CalculateLayoutInputVertical);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutHorizontal", UnityEngineUIGridLayoutGroup_m_SetLayoutHorizontal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetLayoutVertical", UnityEngineUIGridLayoutGroup_m_SetLayoutVertical);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "startCorner", UnityEngineUIGridLayoutGroup_g_get_startCorner);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "startAxis", UnityEngineUIGridLayoutGroup_g_get_startAxis);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "cellSize", UnityEngineUIGridLayoutGroup_g_get_cellSize);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "spacing", UnityEngineUIGridLayoutGroup_g_get_spacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constraint", UnityEngineUIGridLayoutGroup_g_get_constraint);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "constraintCount", UnityEngineUIGridLayoutGroup_g_get_constraintCount);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "startCorner", UnityEngineUIGridLayoutGroup_s_set_startCorner);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "startAxis", UnityEngineUIGridLayoutGroup_s_set_startAxis);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "cellSize", UnityEngineUIGridLayoutGroup_s_set_cellSize);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "spacing", UnityEngineUIGridLayoutGroup_s_set_spacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "constraint", UnityEngineUIGridLayoutGroup_s_set_constraint);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "constraintCount", UnityEngineUIGridLayoutGroup_s_set_constraintCount);
            
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceUnityEngineUIGridLayoutGroup, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceUnityEngineUIGridLayoutGroup(RealStatePtr L, int gen_param_count) 
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.GridLayoutGroup does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        int UnityEngineUIGridLayoutGroup_m_CalculateLayoutInputHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIGridLayoutGroup_m_CalculateLayoutInputVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.CalculateLayoutInputVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIGridLayoutGroup_m_SetLayoutHorizontal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetLayoutHorizontal(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int UnityEngineUIGridLayoutGroup_m_SetLayoutVertical(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.SetLayoutVertical(  );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int UnityEngineUIGridLayoutGroup_g_get_startCorner(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.startCorner);
            return 1;
        }
        
        int UnityEngineUIGridLayoutGroup_g_get_startAxis(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.startAxis);
            return 1;
        }
        
        int UnityEngineUIGridLayoutGroup_g_get_cellSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.cellSize);
            return 1;
        }
        
        int UnityEngineUIGridLayoutGroup_g_get_spacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
			translator.PushUnityEngineVector2(L, gen_to_be_invoked.spacing);
            return 1;
        }
        
        int UnityEngineUIGridLayoutGroup_g_get_constraint(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.constraint);
            return 1;
        }
        
        int UnityEngineUIGridLayoutGroup_g_get_constraintCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
			LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.constraintCount);
            return 1;
        }
        
        
        
        int UnityEngineUIGridLayoutGroup_s_set_startCorner(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.GridLayoutGroup.Corner gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.startCorner = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIGridLayoutGroup_s_set_startAxis(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.GridLayoutGroup.Axis gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.startAxis = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIGridLayoutGroup_s_set_cellSize(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.cellSize = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIGridLayoutGroup_s_set_spacing(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            UnityEngine.Vector2 gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.spacing = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIGridLayoutGroup_s_set_constraint(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            UnityEngine.UI.GridLayoutGroup.Constraint gen_value;translator.Get(L, 2, out gen_value);
			gen_to_be_invoked.constraint = gen_value;
            
            return 0;
        }
        
        int UnityEngineUIGridLayoutGroup_s_set_constraintCount(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
            UnityEngine.UI.GridLayoutGroup gen_to_be_invoked = (UnityEngine.UI.GridLayoutGroup)translator.FastGetCSObj(L, 1);
            gen_to_be_invoked.constraintCount = LuaAPI.xlua_tointeger(L, 2);
            
            return 0;
        }
        
		
		
		
		
    }
}
