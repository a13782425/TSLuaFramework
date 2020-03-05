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


namespace XLua
{
    public partial class ObjectTranslator
    {
        public void __RegisterSystemIOBinaryWriter(RealStatePtr L) 
        {
		    System.Type type = typeof(System.IO.BinaryWriter);
			Utils.BeginObjectRegister(type, L, this, 0, 21, 1, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Close", SystemIOBinaryWriter_m_Close);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Dispose", SystemIOBinaryWriter_m_Dispose);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Flush", SystemIOBinaryWriter_m_Flush);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Seek", SystemIOBinaryWriter_m_Seek);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Write", SystemIOBinaryWriter_m_Write);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteDouble", SystemIOBinaryWriter_m_WriteDouble);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteULong", SystemIOBinaryWriter_m_WriteULong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteUInt", SystemIOBinaryWriter_m_WriteUInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteUShort", SystemIOBinaryWriter_m_WriteUShort);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteString", SystemIOBinaryWriter_m_WriteString);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteFloat", SystemIOBinaryWriter_m_WriteFloat);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteSbyte", SystemIOBinaryWriter_m_WriteSbyte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteLong", SystemIOBinaryWriter_m_WriteLong);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteInt", SystemIOBinaryWriter_m_WriteInt);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteChars", SystemIOBinaryWriter_m_WriteChars);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteDecimal", SystemIOBinaryWriter_m_WriteDecimal);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteChar", SystemIOBinaryWriter_m_WriteChar);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBuffer", SystemIOBinaryWriter_m_WriteBuffer);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteByte", SystemIOBinaryWriter_m_WriteByte);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteBool", SystemIOBinaryWriter_m_WriteBool);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "WriteShort", SystemIOBinaryWriter_m_WriteShort);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "BaseStream", SystemIOBinaryWriter_g_get_BaseStream);
            
			
			
			Utils.EndObjectRegister(type, L, this, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstanceSystemIOBinaryWriter, 2, 0, 0);
			
			
            Utils.RegisterObject(L, this, Utils.CLS_IDX, "Null", System.IO.BinaryWriter.Null);
            
			
			
			
			Utils.EndClassRegister(type, L, this);
        }
        
        int __CreateInstanceSystemIOBinaryWriter(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
			if(gen_param_count == 2 && translator.Assignable<System.IO.Stream>(L, 2))
			{
				System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
				
				System.IO.BinaryWriter gen_ret = new System.IO.BinaryWriter(_output);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 3 && translator.Assignable<System.IO.Stream>(L, 2) && translator.Assignable<System.Text.Encoding>(L, 3))
			{
				System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
				System.Text.Encoding _encoding = (System.Text.Encoding)translator.GetObject(L, 3, typeof(System.Text.Encoding));
				
				System.IO.BinaryWriter gen_ret = new System.IO.BinaryWriter(_output, _encoding);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			if(gen_param_count == 4 && translator.Assignable<System.IO.Stream>(L, 2) && translator.Assignable<System.Text.Encoding>(L, 3) && LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4))
			{
				System.IO.Stream _output = (System.IO.Stream)translator.GetObject(L, 2, typeof(System.IO.Stream));
				System.Text.Encoding _encoding = (System.Text.Encoding)translator.GetObject(L, 3, typeof(System.Text.Encoding));
				bool _leaveOpen = LuaAPI.lua_toboolean(L, 4);
				
				System.IO.BinaryWriter gen_ret = new System.IO.BinaryWriter(_output, _encoding, _leaveOpen);
				translator.Push(L, gen_ret);
				
				return 1;
			}
			
			
            return LuaAPI.luaL_error(L, "invalid arguments to System.IO.BinaryWriter constructor!");
            
        }
        
		
        
		
        
        
        
        
        int SystemIOBinaryWriter_m_Close(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Close(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_Dispose(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Dispose(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_Flush(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				
				gen_to_be_invoked.Flush(  );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_Seek(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				int _offset = LuaAPI.xlua_tointeger(L, 2);
				System.IO.SeekOrigin _origin;translator.Get(L, 3, out _origin);
				
				long gen_ret = gen_to_be_invoked.Seek( _offset, _origin );
				LuaAPI.lua_pushint64(L, gen_ret);
				
				
				
				return 1;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_Write(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
			{
				bool _value = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				byte _value = (byte)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				sbyte _value = (sbyte)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				char _ch = (char)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Write( _ch );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				double _value = LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				short _value = (short)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				int _value = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				uint _value = LuaAPI.xlua_touint(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isint64(L, 2))) 
			{
				long _value = LuaAPI.lua_toint64(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || LuaAPI.lua_isuint64(L, 2))) 
			{
				ulong _value = LuaAPI.lua_touint64(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)) 
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
				
				gen_to_be_invoked.Write( _buffer );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& translator.Assignable<char[]>(L, 2)) 
			{
				char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
				
				gen_to_be_invoked.Write( _chars );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2) || translator.IsDecimal(L, 2))) 
			{
				decimal _value;translator.Get(L, 2, out _value);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				string _value = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.Write( _value );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
				int _index = LuaAPI.xlua_tointeger(L, 3);
				int _count = LuaAPI.xlua_tointeger(L, 4);
				
				gen_to_be_invoked.Write( _buffer, _index, _count );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& translator.Assignable<char[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
				int _index = LuaAPI.xlua_tointeger(L, 3);
				int _count = LuaAPI.xlua_tointeger(L, 4);
				
				gen_to_be_invoked.Write( _chars, _index, _count );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.IO.BinaryWriter.Write!");
            
        }
        
        int SystemIOBinaryWriter_m_WriteDouble(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				double _value = LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.WriteDouble( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteULong(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				ulong _value = LuaAPI.lua_touint64(L, 2);
				
				gen_to_be_invoked.WriteULong( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteUInt(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				uint _value = LuaAPI.xlua_touint(L, 2);
				
				gen_to_be_invoked.WriteUInt( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteUShort(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				ushort _value = (ushort)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.WriteUShort( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteString(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				string _value = LuaAPI.lua_tostring(L, 2);
				
				gen_to_be_invoked.WriteString( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteFloat(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				float _value = (float)LuaAPI.lua_tonumber(L, 2);
				
				gen_to_be_invoked.WriteFloat( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteSbyte(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				sbyte _value = (sbyte)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.WriteSbyte( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteLong(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				long _value = LuaAPI.lua_toint64(L, 2);
				
				gen_to_be_invoked.WriteLong( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteInt(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				int _value = LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.WriteInt( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteChars(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& translator.Assignable<char[]>(L, 2)) 
			{
				char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
				
				gen_to_be_invoked.WriteChars( _chars );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& translator.Assignable<char[]>(L, 2)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				char[] _chars = (char[])translator.GetObject(L, 2, typeof(char[]));
				int _index = LuaAPI.xlua_tointeger(L, 3);
				int _count = LuaAPI.xlua_tointeger(L, 4);
				
				gen_to_be_invoked.WriteChars( _chars, _index, _count );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.IO.BinaryWriter.WriteChars!");
            
        }
        
        int SystemIOBinaryWriter_m_WriteDecimal(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				decimal _value;translator.Get(L, 2, out _value);
				
				gen_to_be_invoked.WriteDecimal( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteChar(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				char _ch = (char)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.WriteChar( _ch );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteBuffer(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
			{
				byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
				
				gen_to_be_invoked.WriteBuffer( _buffer );
				
				
				
				return 0;
			}
			if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
			{
				byte[] _buffer = LuaAPI.lua_tobytes(L, 2);
				int _index = LuaAPI.xlua_tointeger(L, 3);
				int _count = LuaAPI.xlua_tointeger(L, 4);
				
				gen_to_be_invoked.WriteBuffer( _buffer, _index, _count );
				
				
				
				return 0;
			}
			
            
            return LuaAPI.luaL_error(L, "invalid arguments to System.IO.BinaryWriter.WriteBuffer!");
            
        }
        
        int SystemIOBinaryWriter_m_WriteByte(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				byte _value = (byte)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.WriteByte( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteBool(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				bool _value = LuaAPI.lua_toboolean(L, 2);
				
				gen_to_be_invoked.WriteBool( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        int SystemIOBinaryWriter_m_WriteShort(RealStatePtr L, int gen_param_count) 
        {
            
            ObjectTranslator translator = this;
            
            
            System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
            
			
			{
				short _value = (short)LuaAPI.xlua_tointeger(L, 2);
				
				gen_to_be_invoked.WriteShort( _value );
				
				
				
				return 0;
			}
			
            
        }
        
        
        
        
        int SystemIOBinaryWriter_g_get_BaseStream(RealStatePtr L, int gen_param_count) 
        {
            ObjectTranslator translator = this;
			
			System.IO.BinaryWriter gen_to_be_invoked = (System.IO.BinaryWriter)translator.FastGetCSObj(L, 1);
			translator.Push(L, gen_to_be_invoked.BaseStream);
            return 1;
        }
        
        
        
		
		
		
		
    }
}
