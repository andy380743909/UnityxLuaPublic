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
    public class GlobalAssetConfigWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GlobalAssetConfig);
			Utils.BeginObjectRegister(type, L, translator, 0, 1, 19, 18);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "OnLoad", _m_OnLoad);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "startModId", _g_get_startModId);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "rootLuaFile", _g_get_rootLuaFile);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultTranslator", _g_get_defaultTranslator);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultBeHitClip", _g_get_defaultBeHitClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultMoveClip", _g_get_defaultMoveClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultIdleClip", _g_get_defaultIdleClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultStunClip", _g_get_defaultStunClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "anqiClip", _g_get_anqiClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "useItemClip", _g_get_useItemClip);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultAnimatorController", _g_get_defaultAnimatorController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultNPCAnimatorController", _g_get_defaultNPCAnimatorController);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultDieClips", _g_get_defaultDieClips);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bigMapIdleClips", _g_get_bigMapIdleClips);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vcam3rdPrefab", _g_get_vcam3rdPrefab);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultVcamOffset", _g_get_defaultVcamOffset);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "vcamOffsetClose", _g_get_vcamOffsetClose);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "defaultHomeName", _g_get_defaultHomeName);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CachedPrefabs", _g_get_CachedPrefabs);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "CachePrefabDict", _g_get_CachePrefabDict);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "startModId", _s_set_startModId);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "rootLuaFile", _s_set_rootLuaFile);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultTranslator", _s_set_defaultTranslator);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultBeHitClip", _s_set_defaultBeHitClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultMoveClip", _s_set_defaultMoveClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultIdleClip", _s_set_defaultIdleClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultStunClip", _s_set_defaultStunClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "anqiClip", _s_set_anqiClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "useItemClip", _s_set_useItemClip);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultAnimatorController", _s_set_defaultAnimatorController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultNPCAnimatorController", _s_set_defaultNPCAnimatorController);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultDieClips", _s_set_defaultDieClips);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "bigMapIdleClips", _s_set_bigMapIdleClips);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vcam3rdPrefab", _s_set_vcam3rdPrefab);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultVcamOffset", _s_set_defaultVcamOffset);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "vcamOffsetClose", _s_set_vcamOffsetClose);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "defaultHomeName", _s_set_defaultHomeName);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "CachedPrefabs", _s_set_CachedPrefabs);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Instance", _s_set_Instance);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new GlobalAssetConfig();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GlobalAssetConfig constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OnLoad(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.OnLoad(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, GlobalAssetConfig.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_startModId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.startModId);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_rootLuaFile(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.rootLuaFile);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultTranslator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultTranslator);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultBeHitClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultBeHitClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultMoveClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultMoveClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultIdleClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultIdleClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultStunClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultStunClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_anqiClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.anqiClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_useItemClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.useItemClip);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultAnimatorController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultNPCAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultNPCAnimatorController);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultDieClips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.defaultDieClips);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bigMapIdleClips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bigMapIdleClips);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vcam3rdPrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.vcam3rdPrefab);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultVcamOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.defaultVcamOffset);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_vcamOffsetClose(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector3(L, gen_to_be_invoked.vcamOffsetClose);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_defaultHomeName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.defaultHomeName);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CachedPrefabs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CachedPrefabs);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_CachePrefabDict(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.CachePrefabDict);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    GlobalAssetConfig.Instance = (GlobalAssetConfig)translator.GetObject(L, 1, typeof(GlobalAssetConfig));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_startModId(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.startModId = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_rootLuaFile(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.rootLuaFile = (UnityEngine.TextAsset)translator.GetObject(L, 2, typeof(UnityEngine.TextAsset));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultTranslator(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultTranslator = (i18n.Translator)translator.GetObject(L, 2, typeof(i18n.Translator));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultBeHitClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultBeHitClip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultMoveClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultMoveClip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultIdleClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultIdleClip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultStunClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultStunClip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_anqiClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.anqiClip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_useItemClip(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.useItemClip = (UnityEngine.AnimationClip)translator.GetObject(L, 2, typeof(UnityEngine.AnimationClip));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultAnimatorController = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultNPCAnimatorController(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultNPCAnimatorController = (UnityEngine.RuntimeAnimatorController)translator.GetObject(L, 2, typeof(UnityEngine.RuntimeAnimatorController));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultDieClips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultDieClips = (System.Collections.Generic.List<UnityEngine.AnimationClip>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.AnimationClip>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_bigMapIdleClips(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.bigMapIdleClips = (System.Collections.Generic.List<UnityEngine.AnimationClip>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.AnimationClip>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vcam3rdPrefab(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.vcam3rdPrefab = (UnityEngine.GameObject)translator.GetObject(L, 2, typeof(UnityEngine.GameObject));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultVcamOffset(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.defaultVcamOffset = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_vcamOffsetClose(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                UnityEngine.Vector3 gen_value;translator.Get(L, 2, out gen_value);
				gen_to_be_invoked.vcamOffsetClose = gen_value;
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_defaultHomeName(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.defaultHomeName = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_CachedPrefabs(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                GlobalAssetConfig gen_to_be_invoked = (GlobalAssetConfig)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.CachedPrefabs = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
