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
    public class UnityEngineGraphicsBufferWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.GraphicsBuffer);
			Utils.BeginObjectRegister(type, L, translator, 0, 7, 5, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", _m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Release", _m_Release);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "IsValid", _m_IsValid);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetData", _m_SetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetData", _m_GetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetNativeBufferPtr", _m_GetNativeBufferPtr);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetCounterValue", _m_SetCounterValue);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "count", _g_get_count);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "stride", _g_get_stride);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "target", _g_get_target);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "usageFlags", _g_get_usageFlags);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "bufferHandle", _g_get_bufferHandle);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "name", _s_set_name);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 2, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "CopyCount", _m_CopyCount_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 4 && translator.Assignable<UnityEngine.GraphicsBuffer.Target>(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4))
				{
					UnityEngine.GraphicsBuffer.Target _target;translator.Get(L, 2, out _target);
					int _count = LuaAPI.xlua_tointeger(L, 3);
					int _stride = LuaAPI.xlua_tointeger(L, 4);
					
					var gen_ret = new UnityEngine.GraphicsBuffer(_target, _count, _stride);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 5 && translator.Assignable<UnityEngine.GraphicsBuffer.Target>(L, 2) && translator.Assignable<UnityEngine.GraphicsBuffer.UsageFlags>(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5))
				{
					UnityEngine.GraphicsBuffer.Target _target;translator.Get(L, 2, out _target);
					UnityEngine.GraphicsBuffer.UsageFlags _usageFlags;translator.Get(L, 3, out _usageFlags);
					int _count = LuaAPI.xlua_tointeger(L, 4);
					int _stride = LuaAPI.xlua_tointeger(L, 5);
					
					var gen_ret = new UnityEngine.GraphicsBuffer(_target, _usageFlags, _count, _stride);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GraphicsBuffer constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Dispose(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Dispose(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Release(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.Release(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_IsValid(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.IsValid(  );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Array>(L, 2)) 
                {
                    System.Array _data = (System.Array)translator.GetObject(L, 2, typeof(System.Array));
                    
                    gen_to_be_invoked.SetData( _data );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Array>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Array _data = (System.Array)translator.GetObject(L, 2, typeof(System.Array));
                    int _managedBufferStartIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _graphicsBufferStartIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.SetData( _data, _managedBufferStartIndex, _graphicsBufferStartIndex, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GraphicsBuffer.SetData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Array>(L, 2)) 
                {
                    System.Array _data = (System.Array)translator.GetObject(L, 2, typeof(System.Array));
                    
                    gen_to_be_invoked.GetData( _data );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 5&& translator.Assignable<System.Array>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    System.Array _data = (System.Array)translator.GetObject(L, 2, typeof(System.Array));
                    int _managedBufferStartIndex = LuaAPI.xlua_tointeger(L, 3);
                    int _computeBufferStartIndex = LuaAPI.xlua_tointeger(L, 4);
                    int _count = LuaAPI.xlua_tointeger(L, 5);
                    
                    gen_to_be_invoked.GetData( _data, _managedBufferStartIndex, _computeBufferStartIndex, _count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GraphicsBuffer.GetData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetNativeBufferPtr(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                        var gen_ret = gen_to_be_invoked.GetNativeBufferPtr(  );
                        LuaAPI.lua_pushlightuserdata(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetCounterValue(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    uint _counterValue = LuaAPI.xlua_touint(L, 2);
                    
                    gen_to_be_invoked.SetCounterValue( _counterValue );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyCount_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.ComputeBuffer _src = (UnityEngine.ComputeBuffer)translator.GetObject(L, 1, typeof(UnityEngine.ComputeBuffer));
                    UnityEngine.ComputeBuffer _dst = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    int _dstOffsetBytes = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.GraphicsBuffer.CopyCount( _src, _dst, _dstOffsetBytes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 1)&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.GraphicsBuffer _src = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 1, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.ComputeBuffer _dst = (UnityEngine.ComputeBuffer)translator.GetObject(L, 2, typeof(UnityEngine.ComputeBuffer));
                    int _dstOffsetBytes = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.GraphicsBuffer.CopyCount( _src, _dst, _dstOffsetBytes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.ComputeBuffer>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.ComputeBuffer _src = (UnityEngine.ComputeBuffer)translator.GetObject(L, 1, typeof(UnityEngine.ComputeBuffer));
                    UnityEngine.GraphicsBuffer _dst = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _dstOffsetBytes = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.GraphicsBuffer.CopyCount( _src, _dst, _dstOffsetBytes );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 1)&& translator.Assignable<UnityEngine.GraphicsBuffer>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.GraphicsBuffer _src = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 1, typeof(UnityEngine.GraphicsBuffer));
                    UnityEngine.GraphicsBuffer _dst = (UnityEngine.GraphicsBuffer)translator.GetObject(L, 2, typeof(UnityEngine.GraphicsBuffer));
                    int _dstOffsetBytes = LuaAPI.xlua_tointeger(L, 3);
                    
                    UnityEngine.GraphicsBuffer.CopyCount( _src, _dst, _dstOffsetBytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.GraphicsBuffer.CopyCount!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_count(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.count);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_stride(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.stride);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_target(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.target);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_usageFlags(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.usageFlags);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_bufferHandle(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.bufferHandle);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_name(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.GraphicsBuffer gen_to_be_invoked = (UnityEngine.GraphicsBuffer)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.name = LuaAPI.lua_tostring(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
