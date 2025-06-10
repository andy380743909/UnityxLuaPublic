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
    public class UnityEngineTexture2DArrayWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(UnityEngine.Texture2DArray);
			Utils.BeginObjectRegister(type, L, translator, 0, 6, 6, 1);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels", _m_GetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetPixels32", _m_GetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels", _m_SetPixels);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetPixels32", _m_SetPixels32);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Apply", _m_Apply);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CopyPixels", _m_CopyPixels);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "depth", _g_get_depth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "format", _g_get_format);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "mipmapLimitGroup", _g_get_mipmapLimitGroup);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "activeMipmapLimit", _g_get_activeMipmapLimit);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "isReadable", _g_get_isReadable);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "ignoreMipmapLimit", _g_get_ignoreMipmapLimit);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "ignoreMipmapLimit", _s_set_ignoreMipmapLimit);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 0);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "allSlices", _g_get_allSlices);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.DefaultFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7) && translator.Assignable<UnityEngine.MipmapLimitDescriptor>(L, 8))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.DefaultFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					UnityEngine.MipmapLimitDescriptor _mipmapLimitDescriptor;translator.Get(L, 8, out _mipmapLimitDescriptor);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags, _mipCount, _mipmapLimitDescriptor);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags, _mipCount);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.Experimental.Rendering.GraphicsFormat>(L, 5) && translator.Assignable<UnityEngine.Experimental.Rendering.TextureCreationFlags>(L, 6) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7) && translator.Assignable<UnityEngine.MipmapLimitDescriptor>(L, 8))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.Experimental.Rendering.GraphicsFormat _format;translator.Get(L, 5, out _format);
					UnityEngine.Experimental.Rendering.TextureCreationFlags _flags;translator.Get(L, 6, out _flags);
					int _mipCount = LuaAPI.xlua_tointeger(L, 7);
					UnityEngine.MipmapLimitDescriptor _mipmapLimitDescriptor;translator.Get(L, 8, out _mipmapLimitDescriptor);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _format, _flags, _mipCount, _mipmapLimitDescriptor);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 9 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8) && translator.Assignable<UnityEngine.MipmapLimitDescriptor>(L, 9))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					bool _createUninitialized = LuaAPI.lua_toboolean(L, 8);
					UnityEngine.MipmapLimitDescriptor _mipmapLimitDescriptor;translator.Get(L, 9, out _mipmapLimitDescriptor);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipCount, _linear, _createUninitialized, _mipmapLimitDescriptor);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					bool _createUninitialized = LuaAPI.lua_toboolean(L, 8);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipCount, _linear, _createUninitialized);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					int _mipCount = LuaAPI.xlua_tointeger(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipCount, _linear);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 8 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 8))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					bool _createUninitialized = LuaAPI.lua_toboolean(L, 8);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipChain, _linear, _createUninitialized);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 7 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 7))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					bool _linear = LuaAPI.lua_toboolean(L, 7);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipChain, _linear);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				if(LuaAPI.lua_gettop(L) == 6 && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3) && LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4) && translator.Assignable<UnityEngine.TextureFormat>(L, 5) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 6))
				{
					int _width = LuaAPI.xlua_tointeger(L, 2);
					int _height = LuaAPI.xlua_tointeger(L, 3);
					int _depth = LuaAPI.xlua_tointeger(L, 4);
					UnityEngine.TextureFormat _textureFormat;translator.Get(L, 5, out _textureFormat);
					bool _mipChain = LuaAPI.lua_toboolean(L, 6);
					
					var gen_ret = new UnityEngine.Texture2DArray(_width, _height, _depth, _textureFormat, _mipChain);
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels( _arrayElement );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels( _arrayElement, _miplevel );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.GetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels32( _arrayElement );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 2);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = gen_to_be_invoked.GetPixels32( _arrayElement, _miplevel );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.GetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color[] _colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPixels( _colors, _arrayElement );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Color[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color[] _colors = (UnityEngine.Color[])translator.GetObject(L, 2, typeof(UnityEngine.Color[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetPixels( _colors, _arrayElement, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.SetPixels!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetPixels32(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Color32[] _colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    
                    gen_to_be_invoked.SetPixels32( _colors, _arrayElement );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Color32[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Color32[] _colors = (UnityEngine.Color32[])translator.GetObject(L, 2, typeof(UnityEngine.Color32[]));
                    int _arrayElement = LuaAPI.xlua_tointeger(L, 3);
                    int _miplevel = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.SetPixels32( _colors, _arrayElement, _miplevel );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.SetPixels32!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Apply(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.Apply(  );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    bool _updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    
                    gen_to_be_invoked.Apply( _updateMipmaps );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    bool _updateMipmaps = LuaAPI.lua_toboolean(L, 2);
                    bool _makeNoLongerReadable = LuaAPI.lua_toboolean(L, 3);
                    
                    gen_to_be_invoked.Apply( _updateMipmaps, _makeNoLongerReadable );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.Apply!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CopyPixels(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Texture>(L, 2)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    
                    gen_to_be_invoked.CopyPixels( _src );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _srcElement = LuaAPI.xlua_tointeger(L, 3);
                    int _srcMip = LuaAPI.xlua_tointeger(L, 4);
                    int _dstElement = LuaAPI.xlua_tointeger(L, 5);
                    int _dstMip = LuaAPI.xlua_tointeger(L, 6);
                    
                    gen_to_be_invoked.CopyPixels( _src, _srcElement, _srcMip, _dstElement, _dstMip );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 12&& translator.Assignable<UnityEngine.Texture>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 9)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 10)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 11)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 12)) 
                {
                    UnityEngine.Texture _src = (UnityEngine.Texture)translator.GetObject(L, 2, typeof(UnityEngine.Texture));
                    int _srcElement = LuaAPI.xlua_tointeger(L, 3);
                    int _srcMip = LuaAPI.xlua_tointeger(L, 4);
                    int _srcX = LuaAPI.xlua_tointeger(L, 5);
                    int _srcY = LuaAPI.xlua_tointeger(L, 6);
                    int _srcWidth = LuaAPI.xlua_tointeger(L, 7);
                    int _srcHeight = LuaAPI.xlua_tointeger(L, 8);
                    int _dstElement = LuaAPI.xlua_tointeger(L, 9);
                    int _dstMip = LuaAPI.xlua_tointeger(L, 10);
                    int _dstX = LuaAPI.xlua_tointeger(L, 11);
                    int _dstY = LuaAPI.xlua_tointeger(L, 12);
                    
                    gen_to_be_invoked.CopyPixels( _src, _srcElement, _srcMip, _srcX, _srcY, _srcWidth, _srcHeight, _dstElement, _dstMip, _dstX, _dstY );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Texture2DArray.CopyPixels!");
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_allSlices(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, UnityEngine.Texture2DArray.allSlices);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_depth(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.depth);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_format(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                translator.Push(L, gen_to_be_invoked.format);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_mipmapLimitGroup(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushstring(L, gen_to_be_invoked.mipmapLimitGroup);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_activeMipmapLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.xlua_pushinteger(L, gen_to_be_invoked.activeMipmapLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_isReadable(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.isReadable);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_ignoreMipmapLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, gen_to_be_invoked.ignoreMipmapLimit);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_ignoreMipmapLimit(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                UnityEngine.Texture2DArray gen_to_be_invoked = (UnityEngine.Texture2DArray)translator.FastGetCSObj(L, 1);
                gen_to_be_invoked.ignoreMipmapLimit = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
