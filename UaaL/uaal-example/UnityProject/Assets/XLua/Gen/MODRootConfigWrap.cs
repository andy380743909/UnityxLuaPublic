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
    public class MODRootConfigWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(MODRootConfig);
			Utils.BeginObjectRegister(type, L, translator, 0, 2, 22, 22);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GenerateConfigs", _m_GenerateConfigs);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CreateModInfo", _m_CreateModInfo);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "ModId", _g_get_ModId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsNativeMod", _g_get_IsNativeMod);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Desc", _g_get_Desc);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Version", _g_get_Version);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ModName", _g_get_ModName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ModRootDir", _g_get_ModRootDir);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "Author", _g_get_Author);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "LuaFilePatten", _g_get_LuaFilePatten);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ModArchiveVersion", _g_get_ModArchiveVersion);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PlayerName", _g_get_PlayerName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "PreloadedLua", _g_get_PreloadedLua);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EnableSaveBigMapOnly", _g_get_EnableSaveBigMapOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EnableKickTeammateBigMapOnly", _g_get_EnableKickTeammateBigMapOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AutoBattleOnly", _g_get_AutoBattleOnly);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "BattleTimeScale", _g_get_BattleTimeScale);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ShowSkillNameInBattle", _g_get_ShowSkillNameInBattle);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsConsoleEnable", _g_get_IsConsoleEnable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ConsoleDisableDifficulty", _g_get_ConsoleDisableDifficulty);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "IsPlayUseItemAnimation", _g_get_IsPlayUseItemAnimation);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "StoryIdNameFixes", _g_get_StoryIdNameFixes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CameraOffsetNear", _g_get_CameraOffsetNear);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CameraOffsetFar", _g_get_CameraOffsetFar);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ModId", _s_set_ModId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsNativeMod", _s_set_IsNativeMod);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Desc", _s_set_Desc);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Version", _s_set_Version);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ModName", _s_set_ModName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ModRootDir", _s_set_ModRootDir);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "Author", _s_set_Author);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "LuaFilePatten", _s_set_LuaFilePatten);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ModArchiveVersion", _s_set_ModArchiveVersion);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PlayerName", _s_set_PlayerName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "PreloadedLua", _s_set_PreloadedLua);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EnableSaveBigMapOnly", _s_set_EnableSaveBigMapOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EnableKickTeammateBigMapOnly", _s_set_EnableKickTeammateBigMapOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AutoBattleOnly", _s_set_AutoBattleOnly);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "BattleTimeScale", _s_set_BattleTimeScale);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ShowSkillNameInBattle", _s_set_ShowSkillNameInBattle);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsConsoleEnable", _s_set_IsConsoleEnable);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ConsoleDisableDifficulty", _s_set_ConsoleDisableDifficulty);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "IsPlayUseItemAnimation", _s_set_IsPlayUseItemAnimation);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "StoryIdNameFixes", _s_set_StoryIdNameFixes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CameraOffsetNear", _s_set_CameraOffsetNear);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CameraOffsetFar", _s_set_CameraOffsetFar);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new MODRootConfig();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to MODRootConfig constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GenerateConfigs(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.GenerateConfigs(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateModInfo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.CreateModInfo(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ModId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsNativeMod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsNativeMod);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Desc(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Desc);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Version(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Version);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ModName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModRootDir(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.ModRootDir);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Author(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.Author);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_LuaFilePatten(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.LuaFilePatten);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ModArchiveVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.ModArchiveVersion);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PlayerName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.PlayerName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_PreloadedLua(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.PreloadedLua);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EnableSaveBigMapOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.EnableSaveBigMapOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EnableKickTeammateBigMapOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.EnableKickTeammateBigMapOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AutoBattleOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.AutoBattleOnly);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_BattleTimeScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.BattleTimeScale);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ShowSkillNameInBattle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ShowSkillNameInBattle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsConsoleEnable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsConsoleEnable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ConsoleDisableDifficulty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ConsoleDisableDifficulty);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_IsPlayUseItemAnimation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.IsPlayUseItemAnimation);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_StoryIdNameFixes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.StoryIdNameFixes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CameraOffsetNear(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.CameraOffsetNear);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CameraOffsetFar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.CameraOffsetFar);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ModId = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsNativeMod(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsNativeMod = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Desc(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Desc = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Version(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Version = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ModName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModRootDir(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ModRootDir = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Author(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.Author = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_LuaFilePatten(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.LuaFilePatten = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ModArchiveVersion(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ModArchiveVersion = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PlayerName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.PlayerName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_PreloadedLua(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.PreloadedLua = (System.Collections.Generic.List<string>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<string>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EnableSaveBigMapOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EnableSaveBigMapOnly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EnableKickTeammateBigMapOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EnableKickTeammateBigMapOnly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AutoBattleOnly(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AutoBattleOnly = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_BattleTimeScale(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.BattleTimeScale = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ShowSkillNameInBattle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ShowSkillNameInBattle = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsConsoleEnable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsConsoleEnable = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ConsoleDisableDifficulty(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ConsoleDisableDifficulty = (System.Collections.Generic.List<Jyx2_GameDifficulty>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<Jyx2_GameDifficulty>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_IsPlayUseItemAnimation(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.IsPlayUseItemAnimation = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_StoryIdNameFixes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.StoryIdNameFixes = (System.Collections.Generic.List<StoryIdNameFix>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<StoryIdNameFix>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CameraOffsetNear(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.CameraOffsetNear = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CameraOffsetFar(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                MODRootConfig gen_to_be_invoked = (MODRootConfig)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.CameraOffsetFar = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
