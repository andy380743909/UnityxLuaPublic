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
    public class FairyBookWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(FairyBook);
			Utils.BeginObjectRegister(type, L, translator, 0, 8, 5, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ConstructFromXML", _m_ConstructFromXML);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetSoftShadowResource", _m_SetSoftShadowResource);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TurnTo", _m_TurnTo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TurnNext", _m_TurnNext);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TurnPrevious", _m_TurnPrevious);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "ShowCover", _m_ShowCover);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "isCoverShowing", _m_isCoverShowing);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "onTurnComplete", _g_get_onTurnComplete);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pageSoftness", _g_get_pageSoftness);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pageCount", _g_get_pageCount);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "currentPage", _g_get_currentPage);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "pageRenderer", _g_get_pageRenderer);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "pageSoftness", _s_set_pageSoftness);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pageCount", _s_set_pageCount);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "currentPage", _s_set_currentPage);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "pageRenderer", _s_set_pageRenderer);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "EffectDuration", _g_get_EffectDuration);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "EffectDuration", _s_set_EffectDuration);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new FairyBook();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to FairyBook constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ConstructFromXML(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyGUI.Utils.XML _xml = (FairyGUI.Utils.XML)translator.GetObject(L, 2, typeof(FairyGUI.Utils.XML));
                    
                    gen_to_be_invoked.ConstructFromXML( _xml );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSoftShadowResource(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _res = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SetSoftShadowResource( _res );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TurnTo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _pageIndex = LuaAPI.xlua_tointeger(L, 2);
                    
                    gen_to_be_invoked.TurnTo( _pageIndex );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TurnNext(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.TurnNext(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TurnPrevious(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.TurnPrevious(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowCover(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyBook.CoverType _cover;translator.Get(L, 2, out _cover);
                    bool _turnEffect = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.ShowCover( _cover, _turnEffect );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_isCoverShowing(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    FairyBook.CoverType _cover;translator.Get(L, 2, out _cover);
                    
                        var gen_ret = gen_to_be_invoked.isCoverShowing( _cover );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_onTurnComplete(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.onTurnComplete);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pageSoftness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                translator.PushFairyBookPaper(L, gen_to_be_invoked.pageSoftness);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pageCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.pageCount);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_currentPage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.currentPage);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_pageRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.pageRenderer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EffectDuration(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushnumber(L, FairyBook.EffectDuration);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pageSoftness(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                FairyBook.Paper gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.pageSoftness = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pageCount(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pageCount = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_currentPage(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.currentPage = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_pageRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                FairyBook gen_to_be_invoked = (FairyBook)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.pageRenderer = translator.GetDelegate<FairyBook.PageRenderer>(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EffectDuration(RealStatePtr L)
        {
		    try {
                
			    FairyBook.EffectDuration = (float)LuaAPI.lua_tonumber(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
