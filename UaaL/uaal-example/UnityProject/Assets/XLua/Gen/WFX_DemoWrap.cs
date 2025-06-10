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
    public class WFX_DemoWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(WFX_Demo);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 17, 17);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "spawnParticle", _m_spawnParticle);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "cameraSpeed", _g_get_cameraSpeed);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "orderedSpawns", _g_get_orderedSpawns);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "step", _g_get_step);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "range", _g_get_range);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "walls", _g_get_walls);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bulletholes", _g_get_bulletholes);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ParticleExamples", _g_get_ParticleExamples);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "wood", _g_get_wood);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "concrete", _g_get_concrete);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "metal", _g_get_metal);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "checker", _g_get_checker);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "woodWall", _g_get_woodWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "concreteWall", _g_get_concreteWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "metalWall", _g_get_metalWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "checkerWall", _g_get_checkerWall);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "m4", _g_get_m4);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "m4fps", _g_get_m4fps);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "cameraSpeed", _s_set_cameraSpeed);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "orderedSpawns", _s_set_orderedSpawns);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "step", _s_set_step);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "range", _s_set_range);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "walls", _s_set_walls);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bulletholes", _s_set_bulletholes);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "ParticleExamples", _s_set_ParticleExamples);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "wood", _s_set_wood);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "concrete", _s_set_concrete);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "metal", _s_set_metal);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "checker", _s_set_checker);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "woodWall", _s_set_woodWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "concreteWall", _s_set_concreteWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "metalWall", _s_set_metalWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "checkerWall", _s_set_checkerWall);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "m4", _s_set_m4);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "m4fps", _s_set_m4fps);
            
			
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
					
					var gen_ret = new WFX_Demo();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to WFX_Demo constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_spawnParticle(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
            
            
                
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
        static int _g_get_cameraSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.cameraSpeed);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_orderedSpawns(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.orderedSpawns);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_step(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.step);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_range(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, gen_to_be_invoked.range);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bulletholes);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ParticleExamples(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.ParticleExamples);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.checkerWall);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.m4fps);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_cameraSpeed(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.cameraSpeed = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_orderedSpawns(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.orderedSpawns = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_step(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.step = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_range(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.range = (float)LuaAPI.lua_tonumber(L, 2);
            
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bulletholes = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ParticleExamples(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ParticleExamples = (UnityEngine.GameObject[])translator.GetObject(L, 2, typeof(UnityEngine.GameObject[]));
            
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.checkerWall = (UnityEngine.Material)translator.GetObject(L, 2, typeof(UnityEngine.Material));
            
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
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
			
                WFX_Demo gen_to_be_invoked = (WFX_Demo)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.m4fps = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
