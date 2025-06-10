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
    public class GameSettingManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameSettingManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 2, 1);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "Init", _m_Init_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SubscribeEnforceEvent", _m_SubscribeEnforceEvent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnsubscribeEnforceEvent", _m_UnsubscribeEnforceEvent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UpdateSetting", _m_UpdateSetting_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetVolume", _m_GetVolume_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGameDifficulty", _m_SetGameDifficulty_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetDifficulty", _m_GetDifficulty_xlua_st_);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "OnDifficultyChange", _e_OnDifficultyChange);
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "settings", _g_get_settings);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MobileMoveMode", _g_get_MobileMoveMode);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MobileMoveMode", _s_set_MobileMoveMode);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "GameSettingManager does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Init_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    GameSettingManager.Init(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SubscribeEnforceEvent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    GameSettingManager.Catalog _setting;translator.Get(L, 1, out _setting);
                    UnityEngine.Events.UnityAction<object> _action = translator.GetDelegate<UnityEngine.Events.UnityAction<object>>(L, 2);
                    bool _enforceImmediately = LuaAPI.lua_toboolean(L, 3);
                    
                    GameSettingManager.SubscribeEnforceEvent( _setting, _action, _enforceImmediately );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnsubscribeEnforceEvent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    GameSettingManager.Catalog _setting;translator.Get(L, 1, out _setting);
                    UnityEngine.Events.UnityAction<object> _action = translator.GetDelegate<UnityEngine.Events.UnityAction<object>>(L, 2);
                    
                    GameSettingManager.UnsubscribeEnforceEvent( _setting, _action );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UpdateSetting_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    GameSettingManager.Catalog _setting;translator.Get(L, 1, out _setting);
                    object _value = translator.GetObject(L, 2, typeof(object));
                    
                    GameSettingManager.UpdateSetting( _setting, _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetVolume_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        var gen_ret = GameSettingManager.GetVolume(  );
                        LuaAPI.lua_pushnumber(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGameDifficulty_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _difficulty = LuaAPI.xlua_tointeger(L, 1);
                    
                    GameSettingManager.SetGameDifficulty( _difficulty );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetDifficulty_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                        var gen_ret = GameSettingManager.GetDifficulty(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_settings(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, GameSettingManager.settings);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MobileMoveMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.PushGameSettingManagerMobileMoveModeType(L, GameSettingManager.MobileMoveMode);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MobileMoveMode(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			GameSettingManager.MobileMoveModeType gen_value;translator.Get(L, 1, out gen_value);
				GameSettingManager.MobileMoveMode = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _e_OnDifficultyChange(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    int gen_param_count = LuaAPI.lua_gettop(L);
                System.Action<Jyx2_GameDifficulty> gen_delegate = translator.GetDelegate<System.Action<Jyx2_GameDifficulty>>(L, 2);
                if (gen_delegate == null) {
                    return LuaAPI.luaL_error(L, "#2 need System.Action<Jyx2_GameDifficulty>!");
                }
                
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "+")) {
					GameSettingManager.OnDifficultyChange += gen_delegate;
					return 0;
				} 
				
				
				if (gen_param_count == 2 && LuaAPI.xlua_is_eq_str(L, 1, "-")) {
					GameSettingManager.OnDifficultyChange -= gen_delegate;
					return 0;
				} 
				
			} catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
			return LuaAPI.luaL_error(L, "invalid arguments to GameSettingManager.OnDifficultyChange!");
        }
        
    }
}
