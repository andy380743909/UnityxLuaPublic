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
    public class ConStrWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(ConStr);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 0, 0);
			
			
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BattleBlockDatasetPath", ConStr.BattleBlockDatasetPath);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "BattleboxDatasetPath", ConStr.BattleboxDatasetPath);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "LevelMaster", ConStr.LevelMaster);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Player", ConStr.Player);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "PlayerPointLight", ConStr.PlayerPointLight);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultSword", ConStr.DefaultSword);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultKnife", ConStr.DefaultKnife);
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DefaultSpear", ConStr.DefaultSpear);
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new ConStr();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to ConStr constructor!");
            
        }
        
		
        
		
        
        
        
        
        
        
        
        
        
		
		
		
		
    }
}
