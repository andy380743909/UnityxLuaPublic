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
    public class GameConstWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameConst);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 20, 31, 4);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetUPNumber", _m_GetUPNumber_xlua_st_);
            
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DEFAULT_GAME_MOD_NAME", GameConst.DEFAULT_GAME_MOD_NAME);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultMainMenuScene", GameConst.DefaultMainMenuScene);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MapAngularSpeed", GameConst.MapAngularSpeed);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MapAcceleration", GameConst.MapAcceleration);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SEMI_REAL", GameConst.SEMI_REAL);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "ACTION_SP", GameConst.ACTION_SP);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MAX_EXP", GameConst.MAX_EXP);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MAX_CHAT_CHART_NUM", GameConst.MAX_CHAT_CHART_NUM);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MAX_BATTLE_RESULT_LINE_NUM", GameConst.MAX_BATTLE_RESULT_LINE_NUM);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_VOLUME", GameConst.PLAYER_PREF_VOLUME);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_SOUND_EFFECT", GameConst.PLAYER_PREF_SOUND_EFFECT);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_RESOLUTION", GameConst.PLAYER_PREF_RESOLUTION);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_FULLSCREEN", GameConst.PLAYER_PREF_FULLSCREEN);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_VIEWPORT_TYPE", GameConst.PLAYER_PREF_VIEWPORT_TYPE);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_Difficulty", GameConst.PLAYER_PREF_Difficulty);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_LANGUAGE", GameConst.PLAYER_PREF_LANGUAGE);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_PREF_DEBUGMODE", GameConst.PLAYER_PREF_DEBUGMODE);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PLAYER_MOBILE_MOVE_MODE", GameConst.PLAYER_MOBILE_MOVE_MODE);
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_LEVEL", _g_get_MAX_ROLE_LEVEL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_TILI", _g_get_MAX_ROLE_TILI);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_POISON", _g_get_MAX_POISON);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_USE_POISON", _g_get_MAX_USE_POISON);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_HEAL", _g_get_MAX_HEAL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_DEPOISON", _g_get_MAX_DEPOISON);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ANTIPOISON", _g_get_MAX_ANTIPOISON);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_HURT", _g_get_MAX_HURT);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "CAM_SMOOTHING", _g_get_CAM_SMOOTHING);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "GAME_START_MUSIC_ID", _g_get_GAME_START_MUSIC_ID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_WEAPON_ATTR", _g_get_MAX_ROLE_WEAPON_ATTR);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_HP", _g_get_MAX_ROLE_HP);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_MP", _g_get_MAX_ROLE_MP);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_ATTACK", _g_get_MAX_ROLE_ATTACK);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_DEFENCE", _g_get_MAX_ROLE_DEFENCE);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_QINGGONG", _g_get_MAX_ROLE_QINGGONG);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_ATK_POISON", _g_get_MAX_ROLE_ATK_POISON);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_SHENGWANG", _g_get_MAX_ROLE_SHENGWANG);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_PINDE", _g_get_MAX_ROLE_PINDE);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_ZIZHI", _g_get_MAX_ROLE_ZIZHI);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_WUGONG_LEVEL", _g_get_MAX_WUGONG_LEVEL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MONEY_ID", _g_get_MONEY_ID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_TEAMCOUNT", _g_get_MAX_TEAMCOUNT);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_SKILL_COUNT", _g_get_MAX_SKILL_COUNT);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_ROLE_ATTRIBUTE", _g_get_MAX_ROLE_ATTRIBUTE);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "_levelUpExpList", _g_get__levelUpExpList);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "SAVE_COUNT", _g_get_SAVE_COUNT);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_SKILL_LEVEL", _g_get_MAX_SKILL_LEVEL);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MAX_BATTLE_TEAMMATE_COUNT", _g_get_MAX_BATTLE_TEAMMATE_COUNT);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WORLD_MAP_ID", _g_get_WORLD_MAP_ID);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "ProItemDic", _g_get_ProItemDic);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MAX_SKILL_LEVEL", _s_set_MAX_SKILL_LEVEL);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "MAX_BATTLE_TEAMMATE_COUNT", _s_set_MAX_BATTLE_TEAMMATE_COUNT);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "WORLD_MAP_ID", _s_set_WORLD_MAP_ID);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "ProItemDic", _s_set_ProItemDic);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new GameConst();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GameConst constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetUPNumber_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = GameConst.GetUPNumber( _index );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_LEVEL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_LEVEL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_TILI(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_TILI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_POISON(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_POISON);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_USE_POISON(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_USE_POISON);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_HEAL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_HEAL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_DEPOISON(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_DEPOISON);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ANTIPOISON(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ANTIPOISON);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_HURT(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_HURT);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CAM_SMOOTHING(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, GameConst.CAM_SMOOTHING);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_GAME_START_MUSIC_ID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.GAME_START_MUSIC_ID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_WEAPON_ATTR(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_WEAPON_ATTR);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_HP(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_HP);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_MP(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_MP);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_ATTACK(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_ATTACK);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_DEFENCE(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_DEFENCE);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_QINGGONG(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_QINGGONG);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_ATK_POISON(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_ATK_POISON);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_SHENGWANG(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_SHENGWANG);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_PINDE(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_PINDE);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_ZIZHI(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_ZIZHI);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_WUGONG_LEVEL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_WUGONG_LEVEL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MONEY_ID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MONEY_ID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_TEAMCOUNT(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_TEAMCOUNT);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_SKILL_COUNT(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_SKILL_COUNT);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_ROLE_ATTRIBUTE(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_ROLE_ATTRIBUTE);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get__levelUpExpList(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, GameConst._levelUpExpList);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_SAVE_COUNT(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.SAVE_COUNT);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_SKILL_LEVEL(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_SKILL_LEVEL);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MAX_BATTLE_TEAMMATE_COUNT(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.MAX_BATTLE_TEAMMATE_COUNT);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WORLD_MAP_ID(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, GameConst.WORLD_MAP_ID);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ProItemDic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, GameConst.ProItemDic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MAX_SKILL_LEVEL(RealStatePtr L)
        {
		    try {
                
			    GameConst.MAX_SKILL_LEVEL = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_MAX_BATTLE_TEAMMATE_COUNT(RealStatePtr L)
        {
		    try {
                
			    GameConst.MAX_BATTLE_TEAMMATE_COUNT = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_WORLD_MAP_ID(RealStatePtr L)
        {
		    try {
                
			    GameConst.WORLD_MAP_ID = LuaAPI.xlua_tointeger(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ProItemDic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    GameConst.ProItemDic = (System.Collections.Generic.Dictionary<string, PropertyItem>)translator.GetObject(L, 1, typeof(System.Collections.Generic.Dictionary<string, PropertyItem>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
