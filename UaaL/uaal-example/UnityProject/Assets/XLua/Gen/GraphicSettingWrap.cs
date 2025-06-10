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


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class GraphicSettingWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GraphicSetting);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 10, 10);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Save", _m_Save);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Load", _m_Load);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Execute", _m_Execute);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExecuteShadowShowLevel", _m_ExecuteShadowShowLevel);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExecuteWaterNormal", _m_ExecuteWaterNormal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ExecuteAntiAliasing", _m_ExecuteAntiAliasing);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasFog", _g_get_HasFog);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasPost", _g_get_HasPost);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasWaterNormal", _g_get_HasWaterNormal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "HasAntiAliasing", _g_get_HasAntiAliasing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Vsync", _g_get_Vsync);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShadowQuality", _g_get_ShadowQuality);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "MaxFps", _g_get_MaxFps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "QualityLevel", _g_get_QualityLevel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShaderLodLevel", _g_get_ShaderLodLevel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShadowShowLevel", _g_get_ShadowShowLevel);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "HasFog", _s_set_HasFog);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HasPost", _s_set_HasPost);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HasWaterNormal", _s_set_HasWaterNormal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "HasAntiAliasing", _s_set_HasAntiAliasing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Vsync", _s_set_Vsync);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ShadowQuality", _s_set_ShadowQuality);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "MaxFps", _s_set_MaxFps);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "QualityLevel", _s_set_QualityLevel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ShaderLodLevel", _s_set_ShaderLodLevel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ShadowShowLevel", _s_set_ShadowShowLevel);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GlobalSetting", _g_get_GlobalSetting);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new GraphicSetting();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GraphicSetting constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Save(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Save(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Load(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Load(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Execute(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Execute(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteShadowShowLevel(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExecuteShadowShowLevel(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteWaterNormal(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExecuteWaterNormal(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ExecuteAntiAliasing(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.ExecuteAntiAliasing(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasFog(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.HasFog);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasPost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.HasPost);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasWaterNormal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.HasWaterNormal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_HasAntiAliasing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.HasAntiAliasing);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Vsync(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.Vsync);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShadowQuality(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ShadowQuality);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MaxFps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                translator.PushMaxFpsEnum(L, gen_to_be_invoked.MaxFps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_QualityLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                translator.PushQualityLevelEnum(L, gen_to_be_invoked.QualityLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShaderLodLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                translator.PushShaderLodLevelEnum(L, gen_to_be_invoked.ShaderLodLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShadowShowLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                translator.PushShadowShowLevelEnum(L, gen_to_be_invoked.ShadowShowLevel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GlobalSetting(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, GraphicSetting.GlobalSetting);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HasFog(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HasFog = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HasPost(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HasPost = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HasWaterNormal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HasWaterNormal = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_HasAntiAliasing(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.HasAntiAliasing = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Vsync(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Vsync = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ShadowQuality(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                UnityEngine.ShadowQuality gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ShadowQuality = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MaxFps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                MaxFpsEnum gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.MaxFps = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_QualityLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                QualityLevelEnum gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.QualityLevel = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ShaderLodLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                ShaderLodLevelEnum gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ShaderLodLevel = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ShadowShowLevel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GraphicSetting gen_to_be_invoked = (GraphicSetting)translator.FastGetCSObj(L, 1);
                ShadowShowLevelEnum gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.ShadowShowLevel = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
