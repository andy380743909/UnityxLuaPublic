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
    public class WFX_Demo_NewWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(WFX_Demo_New);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 24, 24);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnToggleGround", _m_OnToggleGround);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnToggleCamera", _m_OnToggleCamera);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnToggleSlowMo", _m_OnToggleSlowMo);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnPreviousEffect", _m_OnPreviousEffect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnNextEffect", _m_OnNextEffect);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "spawnParticle", _m_spawnParticle);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "groundRenderer", _g_get_groundRenderer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "groundCollider", _g_get_groundCollider);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "slowMoBtn", _g_get_slowMoBtn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "slowMoLabel", _g_get_slowMoLabel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "camRotBtn", _g_get_camRotBtn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "camRotLabel", _g_get_camRotLabel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "groundBtn", _g_get_groundBtn);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "groundLabel", _g_get_groundLabel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EffectLabel", _g_get_EffectLabel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "EffectIndexLabel", _g_get_EffectIndexLabel);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "AdditionalEffects", _g_get_AdditionalEffects);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ground", _g_get_ground);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "walls", _g_get_walls);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bulletholes", _g_get_bulletholes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "m4", _g_get_m4);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "m4fps", _g_get_m4fps);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wood", _g_get_wood);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "concrete", _g_get_concrete);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "metal", _g_get_metal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "checker", _g_get_checker);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "woodWall", _g_get_woodWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "concreteWall", _g_get_concreteWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "metalWall", _g_get_metalWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "checkerWall", _g_get_checkerWall);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "groundRenderer", _s_set_groundRenderer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "groundCollider", _s_set_groundCollider);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "slowMoBtn", _s_set_slowMoBtn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "slowMoLabel", _s_set_slowMoLabel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "camRotBtn", _s_set_camRotBtn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "camRotLabel", _s_set_camRotLabel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "groundBtn", _s_set_groundBtn);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "groundLabel", _s_set_groundLabel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EffectLabel", _s_set_EffectLabel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "EffectIndexLabel", _s_set_EffectIndexLabel);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "AdditionalEffects", _s_set_AdditionalEffects);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ground", _s_set_ground);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "walls", _s_set_walls);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bulletholes", _s_set_bulletholes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "m4", _s_set_m4);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "m4fps", _s_set_m4fps);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wood", _s_set_wood);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "concrete", _s_set_concrete);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "metal", _s_set_metal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "checker", _s_set_checker);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "woodWall", _s_set_woodWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "concreteWall", _s_set_concreteWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "metalWall", _s_set_metalWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "checkerWall", _s_set_checkerWall);
            
			
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
					
					var gen_ret = new WFX_Demo_New();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to WFX_Demo_New constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnToggleGround(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnToggleGround(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnToggleCamera(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnToggleCamera(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnToggleSlowMo(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnToggleSlowMo(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnPreviousEffect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnPreviousEffect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnNextEffect(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.OnNextEffect(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_spawnParticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.spawnParticle(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_groundRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.groundRenderer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_groundCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.groundCollider);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_slowMoBtn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.slowMoBtn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_slowMoLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.slowMoLabel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_camRotBtn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.camRotBtn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_camRotLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.camRotLabel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_groundBtn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.groundBtn);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_groundLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.groundLabel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EffectLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.EffectLabel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_EffectIndexLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.EffectIndexLabel);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_AdditionalEffects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.AdditionalEffects);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ground(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ground);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_walls(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.walls);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bulletholes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bulletholes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m4(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.m4);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m4fps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.m4fps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_wood(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.wood);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_concrete(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.concrete);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_metal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.metal);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_checker(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.checker);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_woodWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.woodWall);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_concreteWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.concreteWall);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_metalWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.metalWall);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_checkerWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.checkerWall);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_groundRenderer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.groundRenderer = (UnityEngine.Renderer)translator.GetObject(L, 2, typeof(UnityEngine.Renderer));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_groundCollider(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.groundCollider = (UnityEngine.Collider)translator.GetObject(L, 2, typeof(UnityEngine.Collider));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_slowMoBtn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.slowMoBtn = (UnityEngine.UI.Image)translator.GetObject(L, 2, typeof(UnityEngine.UI.Image));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_slowMoLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.slowMoLabel = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_camRotBtn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.camRotBtn = (UnityEngine.UI.Image)translator.GetObject(L, 2, typeof(UnityEngine.UI.Image));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_camRotLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.camRotLabel = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_groundBtn(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.groundBtn = (UnityEngine.UI.Image)translator.GetObject(L, 2, typeof(UnityEngine.UI.Image));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_groundLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.groundLabel = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EffectLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EffectLabel = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_EffectIndexLabel(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.EffectIndexLabel = (UnityEngine.UI.Text)translator.GetObject(L, 2, typeof(UnityEngine.UI.Text));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_AdditionalEffects(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.AdditionalEffects = (UnityEngine.GameObject[])translator.GetObject(L, 2, typeof(UnityEngine.GameObject[]));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ground(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ground = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_walls(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.walls = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bulletholes(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bulletholes = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m4(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.m4 = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m4fps(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.m4fps = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_wood(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.wood = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_concrete(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.concrete = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_metal(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.metal = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_checker(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.checker = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_woodWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.woodWall = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_concreteWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.concreteWall = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_metalWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.metalWall = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_checkerWall(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo_New gen_to_be_invoked = (WFX_Demo_New)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.checkerWall = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
