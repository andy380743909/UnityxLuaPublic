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
    
    public class FairyBookPaperWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyBook.Paper), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyBook.Paper), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyBook.Paper), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Soft", FairyBook.Paper.Soft);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hard", FairyBook.Paper.Hard);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyBook.Paper), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyBookPaper(L, (FairyBook.Paper)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Soft"))
                {
                    translator.PushFairyBookPaper(L, FairyBook.Paper.Soft);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hard"))
                {
                    translator.PushFairyBookPaper(L, FairyBook.Paper.Hard);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyBook.Paper!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyBook.Paper! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class FairyBookCoverTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(FairyBook.CoverType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(FairyBook.CoverType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(FairyBook.CoverType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Front", FairyBook.CoverType.Front);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Back", FairyBook.CoverType.Back);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(FairyBook.CoverType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushFairyBookCoverType(L, (FairyBook.CoverType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Front"))
                {
                    translator.PushFairyBookCoverType(L, FairyBook.CoverType.Front);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Back"))
                {
                    translator.PushFairyBookCoverType(L, FairyBook.CoverType.Back);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for FairyBook.CoverType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for FairyBook.CoverType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class AxisOptionsWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(AxisOptions), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(AxisOptions), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(AxisOptions), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Both", AxisOptions.Both);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Horizontal", AxisOptions.Horizontal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Vertical", AxisOptions.Vertical);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(AxisOptions), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushAxisOptions(L, (AxisOptions)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Both"))
                {
                    translator.PushAxisOptions(L, AxisOptions.Both);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Horizontal"))
                {
                    translator.PushAxisOptions(L, AxisOptions.Horizontal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Vertical"))
                {
                    translator.PushAxisOptions(L, AxisOptions.Vertical);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for AxisOptions!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for AxisOptions! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class JoystickTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(JoystickType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(JoystickType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(JoystickType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", JoystickType.Fixed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Floating", JoystickType.Floating);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Dynamic", JoystickType.Dynamic);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(JoystickType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushJoystickType(L, (JoystickType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushJoystickType(L, JoystickType.Fixed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Floating"))
                {
                    translator.PushJoystickType(L, JoystickType.Floating);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Dynamic"))
                {
                    translator.PushJoystickType(L, JoystickType.Dynamic);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for JoystickType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for JoystickType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class Jyx2_MpTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Jyx2_MpType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Jyx2_MpType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Jyx2_MpType), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Yin", Jyx2_MpType.Yin);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Yang", Jyx2_MpType.Yang);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Neutral", Jyx2_MpType.Neutral);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Jyx2_MpType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushJyx2_MpType(L, (Jyx2_MpType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Yin"))
                {
                    translator.PushJyx2_MpType(L, Jyx2_MpType.Yin);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Yang"))
                {
                    translator.PushJyx2_MpType(L, Jyx2_MpType.Yang);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Neutral"))
                {
                    translator.PushJyx2_MpType(L, Jyx2_MpType.Neutral);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Jyx2_MpType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Jyx2_MpType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class Jyx2_GameDifficultyWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Jyx2_GameDifficulty), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Jyx2_GameDifficulty), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Jyx2_GameDifficulty), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Simple", Jyx2_GameDifficulty.Simple);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", Jyx2_GameDifficulty.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Hard", Jyx2_GameDifficulty.Hard);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Jyx2_GameDifficulty), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushJyx2_GameDifficulty(L, (Jyx2_GameDifficulty)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Simple"))
                {
                    translator.PushJyx2_GameDifficulty(L, Jyx2_GameDifficulty.Simple);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushJyx2_GameDifficulty(L, Jyx2_GameDifficulty.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Hard"))
                {
                    translator.PushJyx2_GameDifficulty(L, Jyx2_GameDifficulty.Hard);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Jyx2_GameDifficulty!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Jyx2_GameDifficulty! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class UILayerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(UILayer), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(UILayer), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(UILayer), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MainUI", UILayer.MainUI);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "NormalUI", UILayer.NormalUI);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PopupUI", UILayer.PopupUI);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", UILayer.Top);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(UILayer), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushUILayer(L, (UILayer)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "MainUI"))
                {
                    translator.PushUILayer(L, UILayer.MainUI);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "NormalUI"))
                {
                    translator.PushUILayer(L, UILayer.NormalUI);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "PopupUI"))
                {
                    translator.PushUILayer(L, UILayer.PopupUI);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushUILayer(L, UILayer.Top);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for UILayer!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for UILayer! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class GameSettingManagerCatalogWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(GameSettingManager.Catalog), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(GameSettingManager.Catalog), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(GameSettingManager.Catalog), L, null, 10, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Volume", GameSettingManager.Catalog.Volume);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "SoundEffect", GameSettingManager.Catalog.SoundEffect);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fullscreen", GameSettingManager.Catalog.Fullscreen);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Resolution", GameSettingManager.Catalog.Resolution);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Viewport", GameSettingManager.Catalog.Viewport);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Difficulty", GameSettingManager.Catalog.Difficulty);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Language", GameSettingManager.Catalog.Language);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DebugMode", GameSettingManager.Catalog.DebugMode);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "MobileMoveMode", GameSettingManager.Catalog.MobileMoveMode);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(GameSettingManager.Catalog), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushGameSettingManagerCatalog(L, (GameSettingManager.Catalog)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Volume"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.Volume);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "SoundEffect"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.SoundEffect);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fullscreen"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.Fullscreen);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Resolution"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.Resolution);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Viewport"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.Viewport);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Difficulty"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.Difficulty);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Language"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.Language);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DebugMode"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.DebugMode);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "MobileMoveMode"))
                {
                    translator.PushGameSettingManagerCatalog(L, GameSettingManager.Catalog.MobileMoveMode);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for GameSettingManager.Catalog!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for GameSettingManager.Catalog! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class GameSettingManagerMobileMoveModeTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(GameSettingManager.MobileMoveModeType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(GameSettingManager.MobileMoveModeType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(GameSettingManager.MobileMoveModeType), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Joystick", GameSettingManager.MobileMoveModeType.Joystick);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Click", GameSettingManager.MobileMoveModeType.Click);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(GameSettingManager.MobileMoveModeType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushGameSettingManagerMobileMoveModeType(L, (GameSettingManager.MobileMoveModeType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Joystick"))
                {
                    translator.PushGameSettingManagerMobileMoveModeType(L, GameSettingManager.MobileMoveModeType.Joystick);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Click"))
                {
                    translator.PushGameSettingManagerMobileMoveModeType(L, GameSettingManager.MobileMoveModeType.Click);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for GameSettingManager.MobileMoveModeType!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for GameSettingManager.MobileMoveModeType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class MaxFpsEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(MaxFpsEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(MaxFpsEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(MaxFpsEnum), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fps30", MaxFpsEnum.Fps30);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fps60", MaxFpsEnum.Fps60);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fps120", MaxFpsEnum.Fps120);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fps200", MaxFpsEnum.Fps200);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(MaxFpsEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushMaxFpsEnum(L, (MaxFpsEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fps30"))
                {
                    translator.PushMaxFpsEnum(L, MaxFpsEnum.Fps30);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fps60"))
                {
                    translator.PushMaxFpsEnum(L, MaxFpsEnum.Fps60);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fps120"))
                {
                    translator.PushMaxFpsEnum(L, MaxFpsEnum.Fps120);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Fps200"))
                {
                    translator.PushMaxFpsEnum(L, MaxFpsEnum.Fps200);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for MaxFpsEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for MaxFpsEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class QualityLevelEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(QualityLevelEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(QualityLevelEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(QualityLevelEnum), L, null, 5, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Low", QualityLevelEnum.Low);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mid", QualityLevelEnum.Mid);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", QualityLevelEnum.High);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Extreme", QualityLevelEnum.Extreme);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(QualityLevelEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushQualityLevelEnum(L, (QualityLevelEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Low"))
                {
                    translator.PushQualityLevelEnum(L, QualityLevelEnum.Low);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mid"))
                {
                    translator.PushQualityLevelEnum(L, QualityLevelEnum.Mid);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushQualityLevelEnum(L, QualityLevelEnum.High);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Extreme"))
                {
                    translator.PushQualityLevelEnum(L, QualityLevelEnum.Extreme);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for QualityLevelEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for QualityLevelEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ShaderLodLevelEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ShaderLodLevelEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ShaderLodLevelEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ShaderLodLevelEnum), L, null, 4, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Low", ShaderLodLevelEnum.Low);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Mid", ShaderLodLevelEnum.Mid);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "High", ShaderLodLevelEnum.High);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ShaderLodLevelEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushShaderLodLevelEnum(L, (ShaderLodLevelEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Low"))
                {
                    translator.PushShaderLodLevelEnum(L, ShaderLodLevelEnum.Low);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Mid"))
                {
                    translator.PushShaderLodLevelEnum(L, ShaderLodLevelEnum.Mid);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "High"))
                {
                    translator.PushShaderLodLevelEnum(L, ShaderLodLevelEnum.High);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ShaderLodLevelEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ShaderLodLevelEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class ShadowShowLevelEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(ShadowShowLevelEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(ShadowShowLevelEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(ShadowShowLevelEnum), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Team", ShadowShowLevelEnum.Team);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "All", ShadowShowLevelEnum.All);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(ShadowShowLevelEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushShadowShowLevelEnum(L, (ShadowShowLevelEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "Team"))
                {
                    translator.PushShadowShowLevelEnum(L, ShadowShowLevelEnum.Team);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "All"))
                {
                    translator.PushShadowShowLevelEnum(L, ShadowShowLevelEnum.All);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for ShadowShowLevelEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for ShadowShowLevelEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class TutorialTestEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.TestEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.TestEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.TestEnum), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E1", Tutorial.TestEnum.E1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E2", Tutorial.TestEnum.E2);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.TestEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialTestEnum(L, (Tutorial.TestEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "E1"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E2"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.TestEnum!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.TestEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class TutorialDerivedClassTestEnumInnerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, null, 3, 0, 0);

            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E3", Tutorial.DerivedClass.TestEnumInner.E3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E4", Tutorial.DerivedClass.TestEnumInner.E4);
            

			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.DerivedClass.TestEnumInner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialDerivedClassTestEnumInner(L, (Tutorial.DerivedClass.TestEnumInner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {

			    if (LuaAPI.xlua_is_eq_str(L, 1, "E3"))
                {
                    translator.PushTutorialDerivedClassTestEnumInner(L, Tutorial.DerivedClass.TestEnumInner.E3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E4"))
                {
                    translator.PushTutorialDerivedClassTestEnumInner(L, Tutorial.DerivedClass.TestEnumInner.E4);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.DerivedClass.TestEnumInner!");
                }

            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.DerivedClass.TestEnumInner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}