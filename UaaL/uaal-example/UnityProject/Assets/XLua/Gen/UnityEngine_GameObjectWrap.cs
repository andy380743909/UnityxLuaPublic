﻿#if USE_UNI_LUA
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
    public class UnityEngineGameObjectWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GameObject);
			Utils.BeginObjectRegister(type, L, translator, 0, 17, 9, 3);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponent", _m_GetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInChildren", _m_GetComponentInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentInParent", _m_GetComponentInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponents", _m_GetComponents);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInChildren", _m_GetComponentsInChildren);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentsInParent", _m_GetComponentsInParent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "TryGetComponent", _m_TryGetComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessageUpwards", _m_SendMessageUpwards);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SendMessage", _m_SendMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BroadcastMessage", _m_BroadcastMessage);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddComponent", _m_AddComponent);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentCount", _m_GetComponentCount);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentAtIndex", _m_GetComponentAtIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetComponentIndex", _m_GetComponentIndex);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetActive", _m_SetActive);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CompareTag", _m_CompareTag);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "BetterSetActive", _m_BetterSetActive);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "transform", _g_get_transform);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "layer", _g_get_layer);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeSelf", _g_get_activeSelf);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeInHierarchy", _g_get_activeInHierarchy);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isStatic", _g_get_isStatic);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "tag", _g_get_tag);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "scene", _g_get_scene);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "sceneCullingMask", _g_get_sceneCullingMask);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "gameObject", _g_get_gameObject);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "layer", _s_set_layer);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "isStatic", _s_set_isStatic);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "tag", _s_set_tag);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 9, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CreatePrimitive", _m_CreatePrimitive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindWithTag", _m_FindWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectsWithTag", _m_FindGameObjectsWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FindGameObjectWithTag", _m_FindGameObjectWithTag_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Find", _m_Find_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGameObjectsActive", _m_SetGameObjectsActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InstantiateGameObjects", _m_InstantiateGameObjects_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetScene", _m_GetScene_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING))
				{
					string _name = LuaAPI.lua_tostring(L, 2);
					
					var gen_ret = new UnityEngine.GameObject(_name);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new UnityEngine.GameObject();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) >= 2 && (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING) && (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 3) || translator.Assignable<System.Type>(L, 3)))
				{
					string _name = LuaAPI.lua_tostring(L, 2);
					System.Type[] _components = translator.GetParams<System.Type>(L, 3);
					
					var gen_ret = new UnityEngine.GameObject(_name, _components);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreatePrimitive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.PrimitiveType _type;translator.Get(L, 1, out _type);
                    
                        var gen_ret = UnityEngine.GameObject.CreatePrimitive( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.GetComponent( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _type = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetComponent( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentInChildren(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.GetComponentInChildren( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetComponentInChildren( _type, _includeInactive );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentInChildren!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentInParent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.GetComponentInParent( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetComponentInParent( _type, _includeInactive );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentInParent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponents(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.GetComponents( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.Component>>(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    System.Collections.Generic.List<UnityEngine.Component> _results = (System.Collections.Generic.List<UnityEngine.Component>)translator.GetObject(L, 3, typeof(System.Collections.Generic.List<UnityEngine.Component>));
                    
                    gen_to_be_invoked.GetComponents( _type, _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponents!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentsInChildren(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.GetComponentsInChildren( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetComponentsInChildren( _type, _includeInactive );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInChildren!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentsInParent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Type>(L, 2)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.GetComponentsInParent( _type );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<System.Type>(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    bool _includeInactive = LuaAPI.lua_toboolean(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetComponentsInParent( _type, _includeInactive );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.GetComponentsInParent!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TryGetComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _type = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    UnityEngine.Component _component;
                    
                        var gen_ret = gen_to_be_invoked.TryGetComponent( _type, out _component );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _component);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindWithTag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _tag = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.GameObject.FindWithTag( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindGameObjectsWithTag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.GameObject.FindGameObjectsWithTag( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Collections.Generic.List<UnityEngine.GameObject>>(L, 2)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 1);
                    System.Collections.Generic.List<UnityEngine.GameObject> _results = (System.Collections.Generic.List<UnityEngine.GameObject>)translator.GetObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.GameObject>));
                    
                    UnityEngine.GameObject.FindGameObjectsWithTag( _tag, _results );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.FindGameObjectsWithTag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendMessageUpwards(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SendMessageUpwards( _methodName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
                    
                    gen_to_be_invoked.SendMessageUpwards( _methodName, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SendMessageUpwards( _methodName, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions _options;translator.Get(L, 4, out _options);
                    
                    gen_to_be_invoked.SendMessageUpwards( _methodName, _value, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessageUpwards!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendMessage(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.SendMessage( _methodName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
                    
                    gen_to_be_invoked.SendMessage( _methodName, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.SendMessage( _methodName, _value );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object _value = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions _options;translator.Get(L, 4, out _options);
                    
                    gen_to_be_invoked.SendMessage( _methodName, _value, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.SendMessage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BroadcastMessage(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.BroadcastMessage( _methodName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SendMessageOptions _options;translator.Get(L, 3, out _options);
                    
                    gen_to_be_invoked.BroadcastMessage( _methodName, _options );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object _parameter = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.BroadcastMessage( _methodName, _parameter );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)&& translator.Assignable<UnityEngine.SendMessageOptions>(L, 4)) 
                {
                    string _methodName = LuaAPI.lua_tostring(L, 2);
                    object _parameter = translator.GetObject(L, 3, typeof(object));
                    UnityEngine.SendMessageOptions _options;translator.Get(L, 4, out _options);
                    
                    gen_to_be_invoked.BroadcastMessage( _methodName, _parameter, _options );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.BroadcastMessage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddComponent(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    System.Type _componentType = (System.Type)translator.GetObject(L, 2, typeof(System.Type));
                    
                        var gen_ret = gen_to_be_invoked.AddComponent( _componentType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentCount(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetComponentCount(  );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentAtIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int _index = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetComponentAtIndex( _index );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponentIndex(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    UnityEngine.Component _component = (UnityEngine.Component)translator.GetObject(L, 2, typeof(UnityEngine.Component));
                    
                        var gen_ret = gen_to_be_invoked.GetComponentIndex( _component );
                        LuaAPI.xlua_pushinteger(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActive(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _value = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.SetActive( _value );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompareTag(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _tag = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.CompareTag( _tag );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.TagHandle>(L, 2)) 
                {
                    UnityEngine.TagHandle _tag;translator.Get(L, 2, out _tag);
                    
                        var gen_ret = gen_to_be_invoked.CompareTag( _tag );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.CompareTag!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FindGameObjectWithTag_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _tag = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.GameObject.FindGameObjectWithTag( _tag );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Find_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _name = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = UnityEngine.GameObject.Find( _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGameObjectsActive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    Unity.Collections.NativeArray<int> _instanceIDs;translator.Get(L, 1, out _instanceIDs);
                    bool _active = LuaAPI.lua_toboolean(L, 2);
                    
                    UnityEngine.GameObject.SetGameObjectsActive( _instanceIDs, _active );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InstantiateGameObjects_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Collections.NativeArray<int>>(L, 3)&& translator.Assignable<Unity.Collections.NativeArray<int>>(L, 4)&& translator.Assignable<UnityEngine.SceneManagement.Scene>(L, 5)) 
                {
                    int _sourceInstanceID = LuaAPI.xlua_tointeger(L, 1);
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Collections.NativeArray<int> _newInstanceIDs;translator.Get(L, 3, out _newInstanceIDs);
                    Unity.Collections.NativeArray<int> _newTransformInstanceIDs;translator.Get(L, 4, out _newTransformInstanceIDs);
                    UnityEngine.SceneManagement.Scene _destinationScene;translator.Get(L, 5, out _destinationScene);
                    
                    UnityEngine.GameObject.InstantiateGameObjects( _sourceInstanceID, _count, _newInstanceIDs, _newTransformInstanceIDs, _destinationScene );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& translator.Assignable<Unity.Collections.NativeArray<int>>(L, 3)&& translator.Assignable<Unity.Collections.NativeArray<int>>(L, 4)) 
                {
                    int _sourceInstanceID = LuaAPI.xlua_tointeger(L, 1);
                    int _count = LuaAPI.xlua_tointeger(L, 2);
                    Unity.Collections.NativeArray<int> _newInstanceIDs;translator.Get(L, 3, out _newInstanceIDs);
                    Unity.Collections.NativeArray<int> _newTransformInstanceIDs;translator.Get(L, 4, out _newTransformInstanceIDs);
                    
                    UnityEngine.GameObject.InstantiateGameObjects( _sourceInstanceID, _count, _newInstanceIDs, _newTransformInstanceIDs );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GameObject.InstantiateGameObjects!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetScene_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    int _instanceID = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = UnityEngine.GameObject.GetScene( _instanceID );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BetterSetActive(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    bool _isActive = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.BetterSetActive( _isActive );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_transform(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.transform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_layer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.layer);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeSelf(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.activeSelf);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeInHierarchy(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.activeInHierarchy);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isStatic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isStatic);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_tag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.tag);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_scene(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.scene);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_sceneCullingMask(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushuint64(L, gen_to_be_invoked.sceneCullingMask);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_gameObject(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.gameObject);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_layer(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.layer = LuaAPI.xlua_tointeger(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_isStatic(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.isStatic = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_tag(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GameObject gen_to_be_invoked = (UnityEngine.GameObject)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.tag = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
