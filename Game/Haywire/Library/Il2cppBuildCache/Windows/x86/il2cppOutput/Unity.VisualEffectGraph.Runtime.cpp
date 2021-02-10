#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// System.Action`1<UnityEngine.VFX.VFXOutputEventArgs>
struct Action_1_t5C8C9298698F95A378E73C4584F33A97EF82A064;
// System.Collections.Generic.IEnumerable`1<System.Object>
struct IEnumerable_1_t52B1AC8D9E5E1ED28DF6C46A37C9A1B00B394F9D;
// System.Collections.Generic.IEnumerable`1<UnityEngine.VFX.Utility.VFXBinderBase>
struct IEnumerable_1_t8135522FB95C3F955C3AA2FCA63959360A179385;
// System.Collections.Generic.List`1<System.Object>
struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5;
// System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>
struct List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802;
// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.IntPtr[]
struct IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6;
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971;
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
// System.Type[]
struct TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755;
// UnityEngine.VFX.Utility.VFXBinderBase[]
struct VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780;
// System.Reflection.Binder
struct Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30;
// UnityEngine.Component
struct Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684;
// UnityEngine.VFX.Utility.ExposedProperty
struct ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577;
// UnityEngine.GameObject
struct GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319;
// System.Collections.IDictionary
struct IDictionary_t99871C56B8EC2452AC5C4CF3831695E617B89D3A;
// System.InvalidOperationException
struct InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB;
// System.Reflection.MemberFilter
struct MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A;
// UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A;
// UnityEngine.PropertyAttribute
struct PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F;
// System.String
struct String_t;
// System.Type
struct Type_t;
// UnityEngine.VFX.Utility.VFXBinderAttribute
struct VFXBinderAttribute_t8252CF8AE234D94EB496574812A125D6F7EE6BE9;
// UnityEngine.VFX.Utility.VFXBinderBase
struct VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD;
// UnityEngine.VFX.VFXEventAttribute
struct VFXEventAttribute_tC4E90458100D52776F591CE62B19FF6051F423EF;
// UnityEngine.VFX.Utility.VFXPropertyBinder
struct VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F;
// UnityEngine.VFX.Utility.VFXPropertyBindingAttribute
struct VFXPropertyBindingAttribute_tE6A3A10164586DB90FCBCFE549DAE3EE1DB69684;
// UnityEngine.VFX.VisualEffect
struct VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA;
// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5;

IL2CPP_EXTERN_C RuntimeClass* Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral1206BF0E339ECCEEF9BF321F277DB0FA5C3D3888;
IL2CPP_EXTERN_C String_t* _stringLiteral68E5CEC31382AB192FF06E62F708EC196A878699;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisVFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F_m7312792A3FC0AA8C4D0C5F7976613507D308112D_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD763AD49B154A8E0EC3DAD23F489B74FF58AC680_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ExposedProperty_op_Implicit_m18DE6FCAB257E7CB7B99E16A18CE224380195099_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD8347DCBE5FCE9446D4005E07B9CA4B89E60F274_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_AddRange_mDF67379D637615B296F87C41C4777E4287062577_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mE6D5EF4702BDF08CBB977C2043B23FD2499C6F60_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Remove_m5E7B7735190D4A1D2A4EE609D21DBFF6BE710D02_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_m35A71CA7B83D420724389D4EFCBDE693EF4385FE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_mB9501A53AA026CCD393ECEB536029F9D5EB44A99_RuntimeMethod_var;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE;
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A;
struct VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct  U3CModuleU3E_tD39EC808C4DC9BC4FFD713D663A9C1C6184AE50B 
{
public:

public:
};


// System.Object


// System.Collections.Generic.List`1<System.Object>
struct  List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____items_1)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__items_1() const { return ____items_1; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5_StaticFields, ____emptyArray_5)); }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* get__emptyArray_5() const { return ____emptyArray_5; }
	inline ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};


// System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>
struct  List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.List`1::_items
	VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject * ____syncRoot_4;

public:
	inline static int32_t get_offset_of__items_1() { return static_cast<int32_t>(offsetof(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802, ____items_1)); }
	inline VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* get__items_1() const { return ____items_1; }
	inline VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780** get_address_of__items_1() { return &____items_1; }
	inline void set__items_1(VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* value)
	{
		____items_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____items_1), (void*)value);
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}

	inline static int32_t get_offset_of__syncRoot_4() { return static_cast<int32_t>(offsetof(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802, ____syncRoot_4)); }
	inline RuntimeObject * get__syncRoot_4() const { return ____syncRoot_4; }
	inline RuntimeObject ** get_address_of__syncRoot_4() { return &____syncRoot_4; }
	inline void set__syncRoot_4(RuntimeObject * value)
	{
		____syncRoot_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____syncRoot_4), (void*)value);
	}
};

struct List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_StaticFields
{
public:
	// T[] System.Collections.Generic.List`1::_emptyArray
	VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* ____emptyArray_5;

public:
	inline static int32_t get_offset_of__emptyArray_5() { return static_cast<int32_t>(offsetof(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_StaticFields, ____emptyArray_5)); }
	inline VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* get__emptyArray_5() const { return ____emptyArray_5; }
	inline VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780** get_address_of__emptyArray_5() { return &____emptyArray_5; }
	inline void set__emptyArray_5(VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* value)
	{
		____emptyArray_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____emptyArray_5), (void*)value);
	}
};

struct Il2CppArrayBounds;

// System.Array


// System.Attribute
struct  Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71  : public RuntimeObject
{
public:

public:
};


// UnityEngine.VFX.Utility.ExposedProperty
struct  ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577  : public RuntimeObject
{
public:
	// System.String UnityEngine.VFX.Utility.ExposedProperty::m_Name
	String_t* ___m_Name_0;
	// System.Int32 UnityEngine.VFX.Utility.ExposedProperty::m_Id
	int32_t ___m_Id_1;

public:
	inline static int32_t get_offset_of_m_Name_0() { return static_cast<int32_t>(offsetof(ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577, ___m_Name_0)); }
	inline String_t* get_m_Name_0() const { return ___m_Name_0; }
	inline String_t** get_address_of_m_Name_0() { return &___m_Name_0; }
	inline void set_m_Name_0(String_t* value)
	{
		___m_Name_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Name_0), (void*)value);
	}

	inline static int32_t get_offset_of_m_Id_1() { return static_cast<int32_t>(offsetof(ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577, ___m_Id_1)); }
	inline int32_t get_m_Id_1() const { return ___m_Id_1; }
	inline int32_t* get_address_of_m_Id_1() { return &___m_Id_1; }
	inline void set_m_Id_1(int32_t value)
	{
		___m_Id_1 = value;
	}
};


// System.Reflection.MemberInfo
struct  MemberInfo_t  : public RuntimeObject
{
public:

public:
};


// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct  ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Boolean
struct  Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Enum
struct  Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.Int32
struct  Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046, ___m_value_0)); }
	inline int32_t get_m_value_0() const { return ___m_value_0; }
	inline int32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(int32_t value)
	{
		___m_value_0 = value;
	}
};


// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// UnityEngine.PropertyAttribute
struct  PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Void
struct  Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// System.Reflection.BindingFlags
struct  BindingFlags_tAAAB07D9AC588F0D55D844E51D7035E96DF94733 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(BindingFlags_tAAAB07D9AC588F0D55D844E51D7035E96DF94733, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Exception
struct  Exception_t  : public RuntimeObject
{
public:
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t * ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject * ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject * ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* ___native_trace_ips_15;

public:
	inline static int32_t get_offset_of__className_1() { return static_cast<int32_t>(offsetof(Exception_t, ____className_1)); }
	inline String_t* get__className_1() const { return ____className_1; }
	inline String_t** get_address_of__className_1() { return &____className_1; }
	inline void set__className_1(String_t* value)
	{
		____className_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____className_1), (void*)value);
	}

	inline static int32_t get_offset_of__message_2() { return static_cast<int32_t>(offsetof(Exception_t, ____message_2)); }
	inline String_t* get__message_2() const { return ____message_2; }
	inline String_t** get_address_of__message_2() { return &____message_2; }
	inline void set__message_2(String_t* value)
	{
		____message_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____message_2), (void*)value);
	}

	inline static int32_t get_offset_of__data_3() { return static_cast<int32_t>(offsetof(Exception_t, ____data_3)); }
	inline RuntimeObject* get__data_3() const { return ____data_3; }
	inline RuntimeObject** get_address_of__data_3() { return &____data_3; }
	inline void set__data_3(RuntimeObject* value)
	{
		____data_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____data_3), (void*)value);
	}

	inline static int32_t get_offset_of__innerException_4() { return static_cast<int32_t>(offsetof(Exception_t, ____innerException_4)); }
	inline Exception_t * get__innerException_4() const { return ____innerException_4; }
	inline Exception_t ** get_address_of__innerException_4() { return &____innerException_4; }
	inline void set__innerException_4(Exception_t * value)
	{
		____innerException_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____innerException_4), (void*)value);
	}

	inline static int32_t get_offset_of__helpURL_5() { return static_cast<int32_t>(offsetof(Exception_t, ____helpURL_5)); }
	inline String_t* get__helpURL_5() const { return ____helpURL_5; }
	inline String_t** get_address_of__helpURL_5() { return &____helpURL_5; }
	inline void set__helpURL_5(String_t* value)
	{
		____helpURL_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____helpURL_5), (void*)value);
	}

	inline static int32_t get_offset_of__stackTrace_6() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTrace_6)); }
	inline RuntimeObject * get__stackTrace_6() const { return ____stackTrace_6; }
	inline RuntimeObject ** get_address_of__stackTrace_6() { return &____stackTrace_6; }
	inline void set__stackTrace_6(RuntimeObject * value)
	{
		____stackTrace_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTrace_6), (void*)value);
	}

	inline static int32_t get_offset_of__stackTraceString_7() { return static_cast<int32_t>(offsetof(Exception_t, ____stackTraceString_7)); }
	inline String_t* get__stackTraceString_7() const { return ____stackTraceString_7; }
	inline String_t** get_address_of__stackTraceString_7() { return &____stackTraceString_7; }
	inline void set__stackTraceString_7(String_t* value)
	{
		____stackTraceString_7 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____stackTraceString_7), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_8() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_8)); }
	inline String_t* get__remoteStackTraceString_8() const { return ____remoteStackTraceString_8; }
	inline String_t** get_address_of__remoteStackTraceString_8() { return &____remoteStackTraceString_8; }
	inline void set__remoteStackTraceString_8(String_t* value)
	{
		____remoteStackTraceString_8 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____remoteStackTraceString_8), (void*)value);
	}

	inline static int32_t get_offset_of__remoteStackIndex_9() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackIndex_9)); }
	inline int32_t get__remoteStackIndex_9() const { return ____remoteStackIndex_9; }
	inline int32_t* get_address_of__remoteStackIndex_9() { return &____remoteStackIndex_9; }
	inline void set__remoteStackIndex_9(int32_t value)
	{
		____remoteStackIndex_9 = value;
	}

	inline static int32_t get_offset_of__dynamicMethods_10() { return static_cast<int32_t>(offsetof(Exception_t, ____dynamicMethods_10)); }
	inline RuntimeObject * get__dynamicMethods_10() const { return ____dynamicMethods_10; }
	inline RuntimeObject ** get_address_of__dynamicMethods_10() { return &____dynamicMethods_10; }
	inline void set__dynamicMethods_10(RuntimeObject * value)
	{
		____dynamicMethods_10 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____dynamicMethods_10), (void*)value);
	}

	inline static int32_t get_offset_of__HResult_11() { return static_cast<int32_t>(offsetof(Exception_t, ____HResult_11)); }
	inline int32_t get__HResult_11() const { return ____HResult_11; }
	inline int32_t* get_address_of__HResult_11() { return &____HResult_11; }
	inline void set__HResult_11(int32_t value)
	{
		____HResult_11 = value;
	}

	inline static int32_t get_offset_of__source_12() { return static_cast<int32_t>(offsetof(Exception_t, ____source_12)); }
	inline String_t* get__source_12() const { return ____source_12; }
	inline String_t** get_address_of__source_12() { return &____source_12; }
	inline void set__source_12(String_t* value)
	{
		____source_12 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____source_12), (void*)value);
	}

	inline static int32_t get_offset_of__safeSerializationManager_13() { return static_cast<int32_t>(offsetof(Exception_t, ____safeSerializationManager_13)); }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * get__safeSerializationManager_13() const { return ____safeSerializationManager_13; }
	inline SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F ** get_address_of__safeSerializationManager_13() { return &____safeSerializationManager_13; }
	inline void set__safeSerializationManager_13(SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * value)
	{
		____safeSerializationManager_13 = value;
		Il2CppCodeGenWriteBarrier((void**)(&____safeSerializationManager_13), (void*)value);
	}

	inline static int32_t get_offset_of_captured_traces_14() { return static_cast<int32_t>(offsetof(Exception_t, ___captured_traces_14)); }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* get_captured_traces_14() const { return ___captured_traces_14; }
	inline StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971** get_address_of_captured_traces_14() { return &___captured_traces_14; }
	inline void set_captured_traces_14(StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* value)
	{
		___captured_traces_14 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___captured_traces_14), (void*)value);
	}

	inline static int32_t get_offset_of_native_trace_ips_15() { return static_cast<int32_t>(offsetof(Exception_t, ___native_trace_ips_15)); }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* get_native_trace_ips_15() const { return ___native_trace_ips_15; }
	inline IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6** get_address_of_native_trace_ips_15() { return &___native_trace_ips_15; }
	inline void set_native_trace_ips_15(IntPtrU5BU5D_t27FC72B0409D75AAF33EC42498E8094E95FEE9A6* value)
	{
		___native_trace_ips_15 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___native_trace_ips_15), (void*)value);
	}
};

struct Exception_t_StaticFields
{
public:
	// System.Object System.Exception::s_EDILock
	RuntimeObject * ___s_EDILock_0;

public:
	inline static int32_t get_offset_of_s_EDILock_0() { return static_cast<int32_t>(offsetof(Exception_t_StaticFields, ___s_EDILock_0)); }
	inline RuntimeObject * get_s_EDILock_0() const { return ___s_EDILock_0; }
	inline RuntimeObject ** get_address_of_s_EDILock_0() { return &___s_EDILock_0; }
	inline void set_s_EDILock_0(RuntimeObject * value)
	{
		___s_EDILock_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___s_EDILock_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tDE44F029589A028F8A3053C5C06153FAB4AAE29F * ____safeSerializationManager_13;
	StackTraceU5BU5D_t4AD999C288CB6D1F38A299D12B1598D606588971* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
};

// UnityEngine.HideFlags
struct  HideFlags_tDC64149E37544FF83B2B4222D3E9DC8188766A12 
{
public:
	// System.Int32 UnityEngine.HideFlags::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(HideFlags_tDC64149E37544FF83B2B4222D3E9DC8188766A12, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// UnityEngine.Object
struct  Object_tF2F3778131EFF286AF62B7B013A170F95A91571A  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// System.RuntimeTypeHandle
struct  RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};


// UnityEngine.VFX.Utility.VFXBinderAttribute
struct  VFXBinderAttribute_t8252CF8AE234D94EB496574812A125D6F7EE6BE9  : public PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052
{
public:
	// System.String UnityEngine.VFX.Utility.VFXBinderAttribute::MenuPath
	String_t* ___MenuPath_0;

public:
	inline static int32_t get_offset_of_MenuPath_0() { return static_cast<int32_t>(offsetof(VFXBinderAttribute_t8252CF8AE234D94EB496574812A125D6F7EE6BE9, ___MenuPath_0)); }
	inline String_t* get_MenuPath_0() const { return ___MenuPath_0; }
	inline String_t** get_address_of_MenuPath_0() { return &___MenuPath_0; }
	inline void set_MenuPath_0(String_t* value)
	{
		___MenuPath_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___MenuPath_0), (void*)value);
	}
};


// UnityEngine.VFX.Utility.VFXPropertyBindingAttribute
struct  VFXPropertyBindingAttribute_tE6A3A10164586DB90FCBCFE549DAE3EE1DB69684  : public PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052
{
public:
	// System.String[] UnityEngine.VFX.Utility.VFXPropertyBindingAttribute::EditorTypes
	StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___EditorTypes_0;

public:
	inline static int32_t get_offset_of_EditorTypes_0() { return static_cast<int32_t>(offsetof(VFXPropertyBindingAttribute_tE6A3A10164586DB90FCBCFE549DAE3EE1DB69684, ___EditorTypes_0)); }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* get_EditorTypes_0() const { return ___EditorTypes_0; }
	inline StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A** get_address_of_EditorTypes_0() { return &___EditorTypes_0; }
	inline void set_EditorTypes_0(StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* value)
	{
		___EditorTypes_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___EditorTypes_0), (void*)value);
	}
};


// UnityEngine.Component
struct  Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// UnityEngine.GameObject
struct  GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319  : public Object_tF2F3778131EFF286AF62B7B013A170F95A91571A
{
public:

public:
};


// System.SystemException
struct  SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62  : public Exception_t
{
public:

public:
};


// System.Type
struct  Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  ____impl_9;

public:
	inline static int32_t get_offset_of__impl_9() { return static_cast<int32_t>(offsetof(Type_t, ____impl_9)); }
	inline RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  get__impl_9() const { return ____impl_9; }
	inline RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9 * get_address_of__impl_9() { return &____impl_9; }
	inline void set__impl_9(RuntimeTypeHandle_tC33965ADA3E041E0C94AF05E5CB527B56482CEF9  value)
	{
		____impl_9 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterAttribute_0;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterName_1;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * ___FilterNameIgnoreCase_2;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_3;
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_4;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* ___EmptyTypes_5;
	// System.Reflection.Binder System.Type::defaultBinder
	Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * ___defaultBinder_6;

public:
	inline static int32_t get_offset_of_FilterAttribute_0() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_0)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterAttribute_0() const { return ___FilterAttribute_0; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterAttribute_0() { return &___FilterAttribute_0; }
	inline void set_FilterAttribute_0(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterAttribute_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterAttribute_0), (void*)value);
	}

	inline static int32_t get_offset_of_FilterName_1() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_1)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterName_1() const { return ___FilterName_1; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterName_1() { return &___FilterName_1; }
	inline void set_FilterName_1(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterName_1 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterName_1), (void*)value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_2)); }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * get_FilterNameIgnoreCase_2() const { return ___FilterNameIgnoreCase_2; }
	inline MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 ** get_address_of_FilterNameIgnoreCase_2() { return &___FilterNameIgnoreCase_2; }
	inline void set_FilterNameIgnoreCase_2(MemberFilter_t48D0AA10105D186AF42428FA532D4B4332CF8B81 * value)
	{
		___FilterNameIgnoreCase_2 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FilterNameIgnoreCase_2), (void*)value);
	}

	inline static int32_t get_offset_of_Missing_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_3)); }
	inline RuntimeObject * get_Missing_3() const { return ___Missing_3; }
	inline RuntimeObject ** get_address_of_Missing_3() { return &___Missing_3; }
	inline void set_Missing_3(RuntimeObject * value)
	{
		___Missing_3 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Missing_3), (void*)value);
	}

	inline static int32_t get_offset_of_Delimiter_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_4)); }
	inline Il2CppChar get_Delimiter_4() const { return ___Delimiter_4; }
	inline Il2CppChar* get_address_of_Delimiter_4() { return &___Delimiter_4; }
	inline void set_Delimiter_4(Il2CppChar value)
	{
		___Delimiter_4 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_5)); }
	inline TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* get_EmptyTypes_5() const { return ___EmptyTypes_5; }
	inline TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755** get_address_of_EmptyTypes_5() { return &___EmptyTypes_5; }
	inline void set_EmptyTypes_5(TypeU5BU5D_t85B10489E46F06CEC7C4B1CCBD0E01FAB6649755* value)
	{
		___EmptyTypes_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___EmptyTypes_5), (void*)value);
	}

	inline static int32_t get_offset_of_defaultBinder_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___defaultBinder_6)); }
	inline Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * get_defaultBinder_6() const { return ___defaultBinder_6; }
	inline Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 ** get_address_of_defaultBinder_6() { return &___defaultBinder_6; }
	inline void set_defaultBinder_6(Binder_t2BEE27FD84737D1E79BC47FD67F6D3DD2F2DDA30 * value)
	{
		___defaultBinder_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___defaultBinder_6), (void*)value);
	}
};


// UnityEngine.Behaviour
struct  Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9  : public Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684
{
public:

public:
};


// System.InvalidOperationException
struct  InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB  : public SystemException_tC551B4D6EE3772B5F32C71EE8C719F4B43ECCC62
{
public:

public:
};


// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:

public:
};


// UnityEngine.VFX.VisualEffect
struct  VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA  : public Behaviour_t1A3DDDCF73B4627928FBFE02ED52B7251777DBD9
{
public:
	// UnityEngine.VFX.VFXEventAttribute UnityEngine.VFX.VisualEffect::m_cachedEventAttribute
	VFXEventAttribute_tC4E90458100D52776F591CE62B19FF6051F423EF * ___m_cachedEventAttribute_4;
	// System.Action`1<UnityEngine.VFX.VFXOutputEventArgs> UnityEngine.VFX.VisualEffect::outputEventReceived
	Action_1_t5C8C9298698F95A378E73C4584F33A97EF82A064 * ___outputEventReceived_5;

public:
	inline static int32_t get_offset_of_m_cachedEventAttribute_4() { return static_cast<int32_t>(offsetof(VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA, ___m_cachedEventAttribute_4)); }
	inline VFXEventAttribute_tC4E90458100D52776F591CE62B19FF6051F423EF * get_m_cachedEventAttribute_4() const { return ___m_cachedEventAttribute_4; }
	inline VFXEventAttribute_tC4E90458100D52776F591CE62B19FF6051F423EF ** get_address_of_m_cachedEventAttribute_4() { return &___m_cachedEventAttribute_4; }
	inline void set_m_cachedEventAttribute_4(VFXEventAttribute_tC4E90458100D52776F591CE62B19FF6051F423EF * value)
	{
		___m_cachedEventAttribute_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_cachedEventAttribute_4), (void*)value);
	}

	inline static int32_t get_offset_of_outputEventReceived_5() { return static_cast<int32_t>(offsetof(VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA, ___outputEventReceived_5)); }
	inline Action_1_t5C8C9298698F95A378E73C4584F33A97EF82A064 * get_outputEventReceived_5() const { return ___outputEventReceived_5; }
	inline Action_1_t5C8C9298698F95A378E73C4584F33A97EF82A064 ** get_address_of_outputEventReceived_5() { return &___outputEventReceived_5; }
	inline void set_outputEventReceived_5(Action_1_t5C8C9298698F95A378E73C4584F33A97EF82A064 * value)
	{
		___outputEventReceived_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___outputEventReceived_5), (void*)value);
	}
};


// UnityEngine.VFX.Utility.VFXBinderBase
struct  VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// UnityEngine.VFX.Utility.VFXPropertyBinder UnityEngine.VFX.Utility.VFXBinderBase::binder
	VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * ___binder_4;

public:
	inline static int32_t get_offset_of_binder_4() { return static_cast<int32_t>(offsetof(VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD, ___binder_4)); }
	inline VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * get_binder_4() const { return ___binder_4; }
	inline VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F ** get_address_of_binder_4() { return &___binder_4; }
	inline void set_binder_4(VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * value)
	{
		___binder_4 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___binder_4), (void*)value);
	}
};


// UnityEngine.VFX.Utility.VFXPropertyBinder
struct  VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F  : public MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A
{
public:
	// System.Boolean UnityEngine.VFX.Utility.VFXPropertyBinder::m_ExecuteInEditor
	bool ___m_ExecuteInEditor_4;
	// System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase> UnityEngine.VFX.Utility.VFXPropertyBinder::m_Bindings
	List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * ___m_Bindings_5;
	// UnityEngine.VFX.VisualEffect UnityEngine.VFX.Utility.VFXPropertyBinder::m_VisualEffect
	VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * ___m_VisualEffect_6;

public:
	inline static int32_t get_offset_of_m_ExecuteInEditor_4() { return static_cast<int32_t>(offsetof(VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F, ___m_ExecuteInEditor_4)); }
	inline bool get_m_ExecuteInEditor_4() const { return ___m_ExecuteInEditor_4; }
	inline bool* get_address_of_m_ExecuteInEditor_4() { return &___m_ExecuteInEditor_4; }
	inline void set_m_ExecuteInEditor_4(bool value)
	{
		___m_ExecuteInEditor_4 = value;
	}

	inline static int32_t get_offset_of_m_Bindings_5() { return static_cast<int32_t>(offsetof(VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F, ___m_Bindings_5)); }
	inline List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * get_m_Bindings_5() const { return ___m_Bindings_5; }
	inline List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 ** get_address_of_m_Bindings_5() { return &___m_Bindings_5; }
	inline void set_m_Bindings_5(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * value)
	{
		___m_Bindings_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_Bindings_5), (void*)value);
	}

	inline static int32_t get_offset_of_m_VisualEffect_6() { return static_cast<int32_t>(offsetof(VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F, ___m_VisualEffect_6)); }
	inline VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * get_m_VisualEffect_6() const { return ___m_VisualEffect_6; }
	inline VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA ** get_address_of_m_VisualEffect_6() { return &___m_VisualEffect_6; }
	inline void set_m_VisualEffect_6(VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * value)
	{
		___m_VisualEffect_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_VisualEffect_6), (void*)value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.VFX.Utility.VFXBinderBase[]
struct VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * m_Items[1];

public:
	inline VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.String[]
struct StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) String_t* m_Items[1];

public:
	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Object[]
struct ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) RuntimeObject * m_Items[1];

public:
	inline RuntimeObject * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// !!0 UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject * Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<System.Object>::Contains(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool List_1_Contains_m99C700668AC6D272188471D2D6B784A2B5636C8E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::Add(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<System.Object>::Remove(!0)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool List_1_Remove_m753F7B4281CC4D02C07AE90726F51EF34B588DF7_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject * ___item0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// !!0[] UnityEngine.GameObject::GetComponents<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* GameObject_GetComponents_TisRuntimeObject_mAB26971A1F37F81EEEF20F7897AA6FAE3B33779E_gshared (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<System.Object>::AddRange(System.Collections.Generic.IEnumerable`1<!0>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1_AddRange_m6465DEF706EB529B4227F2AF79338419D517EDF9_gshared (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, RuntimeObject* ___collection0, const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * List_1_get_Item_mF00B574E58FB078BB753B05A3B86DD0A7A266B63_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, int32_t ___index0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m5D847939ABB9A78203B062CAFFE975792174D00F_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method);
// !!0[] UnityEngine.Component::GetComponents<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* Component_GetComponents_TisRuntimeObject_mEBC8AE0C8843120678A284931632FCCBE15F0C46_gshared (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);

// System.Void UnityEngine.VFX.Utility.ExposedProperty::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ExposedProperty__ctor_m0B7742DE4E9F02E0080314F0F2DF868794C83A5A (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * __this, String_t* ___name0, const RuntimeMethod* method);
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C (String_t* ___value0, const RuntimeMethod* method);
// System.Void System.InvalidOperationException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * __this, String_t* ___message0, const RuntimeMethod* method);
// System.Int32 UnityEngine.Shader::PropertyToID(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F (String_t* ___name0, const RuntimeMethod* method);
// System.String System.String::Concat(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B (String_t* ___str00, String_t* ___str11, const RuntimeMethod* method);
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405 (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void UnityEngine.PropertyAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PropertyAttribute__ctor_mA13181D93341AEAE429F0615989CB4647F2EB8A7 (PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052 * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.VFX.Utility.VFXPropertyBinder>()
inline VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * Component_GetComponent_TisVFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F_m7312792A3FC0AA8C4D0C5F7976613507D308112D (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Boolean System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::Contains(!0)
inline bool List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1 (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD *, const RuntimeMethod*))List_1_Contains_m99C700668AC6D272188471D2D6B784A2B5636C8E_gshared)(__this, ___item0, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::Add(!0)
inline void List_1_Add_mE6D5EF4702BDF08CBB977C2043B23FD2499C6F60 (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD *, const RuntimeMethod*))List_1_Add_mE5B3CBB3A625606D9BC4337FEAAF1D66BCB6F96E_gshared)(__this, ___item0, method);
}
// System.Void UnityEngine.Object::set_hideFlags(UnityEngine.HideFlags)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, int32_t ___value0, const RuntimeMethod* method);
// System.Boolean System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::Remove(!0)
inline bool List_1_Remove_m5E7B7735190D4A1D2A4EE609D21DBFF6BE710D02 (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD *, const RuntimeMethod*))List_1_Remove_m753F7B4281CC4D02C07AE90726F51EF34B588DF7_gshared)(__this, ___item0, method);
}
// System.Type System.Object::GetType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Type_t * Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B (RuntimeObject * __this, const RuntimeMethod* method);
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED (MonoBehaviour_t37A501200D970A8257124B0EAE00A0FF3DDC354A * __this, const RuntimeMethod* method);
// !!0 UnityEngine.Component::GetComponent<UnityEngine.VFX.VisualEffect>()
inline VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m69D9C576D6DD024C709E29EEADBC8041299A3AA7_gshared)(__this, method);
}
// System.Boolean UnityEngine.Application::get_isPlaying()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567 (const RuntimeMethod* method);
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, const RuntimeMethod* method);
// System.Void UnityEngine.Object::DestroyImmediate(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_DestroyImmediate_mCCED69F4D4C9A4FA3AC30A142CF3D7F085F7C422 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___obj0, const RuntimeMethod* method);
// System.Void System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::.ctor()
inline void List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84 (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, const RuntimeMethod*))List_1__ctor_m0F0E00088CF56FEACC9E32D8B7D91B93D91DAA3B_gshared)(__this, method);
}
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method);
// !!0[] UnityEngine.GameObject::GetComponents<UnityEngine.VFX.Utility.VFXBinderBase>()
inline VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* GameObject_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD8347DCBE5FCE9446D4005E07B9CA4B89E60F274 (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * __this, const RuntimeMethod* method)
{
	return ((  VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* (*) (GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 *, const RuntimeMethod*))GameObject_GetComponents_TisRuntimeObject_mAB26971A1F37F81EEEF20F7897AA6FAE3B33779E_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::AddRange(System.Collections.Generic.IEnumerable`1<!0>)
inline void List_1_AddRange_mDF67379D637615B296F87C41C4777E4287062577 (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, RuntimeObject* ___collection0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, RuntimeObject*, const RuntimeMethod*))List_1_AddRange_m6465DEF706EB529B4227F2AF79338419D517EDF9_gshared)(__this, ___collection0, method);
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::ClearPropertyBinders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_ClearPropertyBinders_m91FE331E06DB03867E665CF1C8AEB23389C1C835 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method);
// System.Boolean UnityEngine.Application::get_isEditor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Application_get_isEditor_m7367DDB72F13E4846E8EB76FFAAACA84840BE921 (const RuntimeMethod* method);
// !0 System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::get_Item(System.Int32)
inline VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * List_1_get_Item_mB9501A53AA026CCD393ECEB536029F9D5EB44A99_inline (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, int32_t, const RuntimeMethod*))List_1_get_Item_mF00B574E58FB078BB753B05A3B86DD0A7A266B63_gshared_inline)(__this, ___index0, method);
}
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54 (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___x0, Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___y1, const RuntimeMethod* method);
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * __this, const RuntimeMethod* method);
// System.String System.String::Format(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_m8D1CB0410C35E052A53AE957C914C841E54BAB66 (String_t* ___format0, RuntimeObject * ___arg01, RuntimeObject * ___arg12, const RuntimeMethod* method);
// System.Void UnityEngine.Debug::LogWarning(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7 (RuntimeObject * ___message0, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.List`1<UnityEngine.VFX.Utility.VFXBinderBase>::get_Count()
inline int32_t List_1_get_Count_m35A71CA7B83D420724389D4EFCBDE693EF4385FE_inline (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *, const RuntimeMethod*))List_1_get_Count_m5D847939ABB9A78203B062CAFFE975792174D00F_gshared_inline)(__this, method);
}
// !!0[] UnityEngine.Component::GetComponents<UnityEngine.VFX.Utility.VFXBinderBase>()
inline VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* Component_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD763AD49B154A8E0EC3DAD23F489B74FF58AC680 (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 * __this, const RuntimeMethod* method)
{
	return ((  VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* (*) (Component_t62FBC8D2420DA4BE9037AFE430740F6B3EECA684 *, const RuntimeMethod*))Component_GetComponents_TisRuntimeObject_mEBC8AE0C8843120678A284931632FCCBE15F0C46_gshared)(__this, method);
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::SafeDestroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_SafeDestroy_m761D308BA1CF96173734C0D0B7BBD2340B2FA4BE (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___toDelete0, const RuntimeMethod* method);
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::RemovePropertyBinder(UnityEngine.VFX.Utility.VFXBinderBase)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_RemovePropertyBinder_mBC7CE43AE8684F2E0FB16975264A14439D47E013 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * ___binder0, const RuntimeMethod* method);
// System.Void System.ThrowHelper::ThrowArgumentOutOfRangeException()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ThrowHelper_ThrowArgumentOutOfRangeException_m4841366ABC2B2AFA37C10900551D7E07522C0929 (const RuntimeMethod* method);
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.VFX.Utility.ExposedProperty UnityEngine.VFX.Utility.ExposedProperty::op_Implicit(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * ExposedProperty_op_Implicit_m629953E2941B91671467738E985FD910D6ADA7A7 (String_t* ___name0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * V_0 = NULL;
	{
		// return new ExposedProperty(name);
		String_t* L_0 = ___name0;
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_1 = (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 *)il2cpp_codegen_object_new(ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577_il2cpp_TypeInfo_var);
		ExposedProperty__ctor_m0B7742DE4E9F02E0080314F0F2DF868794C83A5A(L_1, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000a;
	}

IL_000a:
	{
		// }
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.VFX.Utility.ExposedProperty::op_Implicit(UnityEngine.VFX.Utility.ExposedProperty)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t ExposedProperty_op_Implicit_m18DE6FCAB257E7CB7B99E16A18CE224380195099 (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * ___parameter0, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	int32_t V_2 = 0;
	int32_t G_B3_0 = 0;
	{
		// if (parameter.m_Id == 0 && !string.IsNullOrEmpty(parameter.m_Name))
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_0 = ___parameter0;
		NullCheck(L_0);
		int32_t L_1 = L_0->get_m_Id_1();
		if (L_1)
		{
			goto IL_0019;
		}
	}
	{
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_2 = ___parameter0;
		NullCheck(L_2);
		String_t* L_3 = L_2->get_m_Name_0();
		bool L_4;
		L_4 = String_IsNullOrEmpty_m9AFBB5335B441B94E884B8A9D4A27AD60E3D7F7C(L_3, /*hidden argument*/NULL);
		G_B3_0 = ((((int32_t)L_4) == ((int32_t)0))? 1 : 0);
		goto IL_001a;
	}

IL_0019:
	{
		G_B3_0 = 0;
	}

IL_001a:
	{
		V_0 = (bool)G_B3_0;
		bool L_5 = V_0;
		if (!L_5)
		{
			goto IL_0029;
		}
	}
	{
		// throw new InvalidOperationException("Unexpected constructor has been called");
		InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB * L_6 = (InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB *)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&InvalidOperationException_t10D3EE59AD28EC641ACEE05BCA4271A527E5ECAB_il2cpp_TypeInfo_var)));
		InvalidOperationException__ctor_mC012CE552988309733C896F3FEA8249171E4402E(L_6, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral1206BF0E339ECCEEF9BF321F277DB0FA5C3D3888)), /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_6, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ExposedProperty_op_Implicit_m18DE6FCAB257E7CB7B99E16A18CE224380195099_RuntimeMethod_var)));
	}

IL_0029:
	{
		// if (parameter.m_Id == -1)
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_7 = ___parameter0;
		NullCheck(L_7);
		int32_t L_8 = L_7->get_m_Id_1();
		V_1 = (bool)((((int32_t)L_8) == ((int32_t)(-1)))? 1 : 0);
		bool L_9 = V_1;
		if (!L_9)
		{
			goto IL_0047;
		}
	}
	{
		// parameter.m_Id = Shader.PropertyToID(parameter.m_Name);
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_10 = ___parameter0;
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_11 = ___parameter0;
		NullCheck(L_11);
		String_t* L_12 = L_11->get_m_Name_0();
		int32_t L_13;
		L_13 = Shader_PropertyToID_m8C1BEBBAC0CC3015B142AF0FA856495D5D239F5F(L_12, /*hidden argument*/NULL);
		NullCheck(L_10);
		L_10->set_m_Id_1(L_13);
	}

IL_0047:
	{
		// return parameter.m_Id;
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_14 = ___parameter0;
		NullCheck(L_14);
		int32_t L_15 = L_14->get_m_Id_1();
		V_2 = L_15;
		goto IL_0050;
	}

IL_0050:
	{
		// }
		int32_t L_16 = V_2;
		return L_16;
	}
}
// UnityEngine.VFX.Utility.ExposedProperty UnityEngine.VFX.Utility.ExposedProperty::op_Addition(UnityEngine.VFX.Utility.ExposedProperty,UnityEngine.VFX.Utility.ExposedProperty)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * ExposedProperty_op_Addition_m71285E209DD1A55CFCF595C4AD63ABC8D54CB58F (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * ___self0, ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * ___other1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * V_0 = NULL;
	{
		// return new ExposedProperty(self.m_Name + other.m_Name);
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_0 = ___self0;
		NullCheck(L_0);
		String_t* L_1 = L_0->get_m_Name_0();
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_2 = ___other1;
		NullCheck(L_2);
		String_t* L_3 = L_2->get_m_Name_0();
		String_t* L_4;
		L_4 = String_Concat_m4B4AB72618348C5DFBFBA8DED84B9E2EBDB55E1B(L_1, L_3, /*hidden argument*/NULL);
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_5 = (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 *)il2cpp_codegen_object_new(ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577_il2cpp_TypeInfo_var);
		ExposedProperty__ctor_m0B7742DE4E9F02E0080314F0F2DF868794C83A5A(L_5, L_4, /*hidden argument*/NULL);
		V_0 = L_5;
		goto IL_001a;
	}

IL_001a:
	{
		// }
		ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * L_6 = V_0;
		return L_6;
	}
}
// System.Void UnityEngine.VFX.Utility.ExposedProperty::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ExposedProperty__ctor_m86D4E10369A7DDC1EB6E699C7EA279A624B9DF2A (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * __this, const RuntimeMethod* method)
{
	{
		// public ExposedProperty()
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// m_Id = -1;
		__this->set_m_Id_1((-1));
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.ExposedProperty::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ExposedProperty__ctor_m0B7742DE4E9F02E0080314F0F2DF868794C83A5A (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	{
		// private ExposedProperty(string name)
		Object__ctor_m88880E0413421D13FD95325EDCE231707CE1F405(__this, /*hidden argument*/NULL);
		// m_Name = name;
		String_t* L_0 = ___name0;
		__this->set_m_Name_0(L_0);
		// m_Id = -1;
		__this->set_m_Id_1((-1));
		// }
		return;
	}
}
// System.String UnityEngine.VFX.Utility.ExposedProperty::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ExposedProperty_ToString_mF92A68B6616003CE87F206ECD37A83EA30377E1A (ExposedProperty_t57A28BBF6D81E8D9F35EF7BCBB758B521E1B0577 * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		// return m_Name;
		String_t* L_0 = __this->get_m_Name_0();
		V_0 = L_0;
		goto IL_000a;
	}

IL_000a:
	{
		// }
		String_t* L_1 = V_0;
		return L_1;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.VFX.Utility.VFXBinderAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXBinderAttribute__ctor_mBA00B7D285E5F63F3D89F436FF9A6A2C4DECA63F (VFXBinderAttribute_t8252CF8AE234D94EB496574812A125D6F7EE6BE9 * __this, String_t* ___menuPath0, const RuntimeMethod* method)
{
	{
		// public VFXBinderAttribute(string menuPath)
		PropertyAttribute__ctor_mA13181D93341AEAE429F0615989CB4647F2EB8A7(__this, /*hidden argument*/NULL);
		// MenuPath = menuPath;
		String_t* L_0 = ___menuPath0;
		__this->set_MenuPath_0(L_0);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.VFX.Utility.VFXBinderBase::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXBinderBase_Reset_m35CC9EB5ED752EBD3FDB4B0B933BE6D0E2D6AE0C (VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * __this, const RuntimeMethod* method)
{
	{
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXBinderBase::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXBinderBase_Awake_m4C942408F3FD7663B12641860ABB506B0FBA0CA0 (VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisVFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F_m7312792A3FC0AA8C4D0C5F7976613507D308112D_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// binder = GetComponent<VFXPropertyBinder>();
		VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * L_0;
		L_0 = Component_GetComponent_TisVFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F_m7312792A3FC0AA8C4D0C5F7976613507D308112D(__this, /*hidden argument*/Component_GetComponent_TisVFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F_m7312792A3FC0AA8C4D0C5F7976613507D308112D_RuntimeMethod_var);
		__this->set_binder_4(L_0);
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXBinderBase::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXBinderBase_OnEnable_m828D21B60D88711C2DD439F3D3A7D423364FBE62 (VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mE6D5EF4702BDF08CBB977C2043B23FD2499C6F60_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// if (!binder.m_Bindings.Contains(this))
		VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * L_0 = __this->get_binder_4();
		NullCheck(L_0);
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_1 = L_0->get_m_Bindings_5();
		NullCheck(L_1);
		bool L_2;
		L_2 = List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1(L_1, __this, /*hidden argument*/List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1_RuntimeMethod_var);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_002b;
		}
	}
	{
		// binder.m_Bindings.Add(this);
		VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * L_4 = __this->get_binder_4();
		NullCheck(L_4);
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_5 = L_4->get_m_Bindings_5();
		NullCheck(L_5);
		List_1_Add_mE6D5EF4702BDF08CBB977C2043B23FD2499C6F60(L_5, __this, /*hidden argument*/List_1_Add_mE6D5EF4702BDF08CBB977C2043B23FD2499C6F60_RuntimeMethod_var);
	}

IL_002b:
	{
		// hideFlags = HideFlags.HideInInspector; 
		Object_set_hideFlags_m7DE229AF60B92F0C68819F77FEB27D775E66F3AC(__this, 2, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXBinderBase::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXBinderBase_OnDisable_mD4319DF68CD63205BC71017AEF8F546945D1DD15 (VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Remove_m5E7B7735190D4A1D2A4EE609D21DBFF6BE710D02_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// if (binder.m_Bindings.Contains(this))
		VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * L_0 = __this->get_binder_4();
		NullCheck(L_0);
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_1 = L_0->get_m_Bindings_5();
		NullCheck(L_1);
		bool L_2;
		L_2 = List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1(L_1, __this, /*hidden argument*/List_1_Contains_mA2BC83140164C6F22AC5F44A8AA8747489348ED1_RuntimeMethod_var);
		V_0 = L_2;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0028;
		}
	}
	{
		// binder.m_Bindings.Remove(this);
		VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * L_4 = __this->get_binder_4();
		NullCheck(L_4);
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_5 = L_4->get_m_Bindings_5();
		NullCheck(L_5);
		bool L_6;
		L_6 = List_1_Remove_m5E7B7735190D4A1D2A4EE609D21DBFF6BE710D02(L_5, __this, /*hidden argument*/List_1_Remove_m5E7B7735190D4A1D2A4EE609D21DBFF6BE710D02_RuntimeMethod_var);
	}

IL_0028:
	{
		// }
		return;
	}
}
// System.String UnityEngine.VFX.Utility.VFXBinderBase::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* VFXBinderBase_ToString_mAC446D3B437AA6D80A4B5EF42A97C6B561F4EC11 (VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		// return GetType().ToString();
		Type_t * L_0;
		L_0 = Object_GetType_m571FE8360C10B98C23AAF1F066D92C08CC94F45B(__this, /*hidden argument*/NULL);
		NullCheck(L_0);
		String_t* L_1;
		L_1 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_0);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		// }
		String_t* L_2 = V_0;
		return L_2;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXBinderBase::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXBinderBase__ctor_m5C82FB8AE297CA9A3CC8C625213F9CC42A2EF5FD (VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * __this, const RuntimeMethod* method)
{
	{
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_OnEnable_mB8F4481D5052CD1A57392B8A85498CC653838A96 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_VisualEffect = GetComponent<VisualEffect>();
		VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * L_0;
		L_0 = Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5(__this, /*hidden argument*/Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5_RuntimeMethod_var);
		__this->set_m_VisualEffect_6(L_0);
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::SafeDestroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_SafeDestroy_m761D308BA1CF96173734C0D0B7BBD2340B2FA4BE (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * ___toDelete0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// if (Application.isPlaying)
		bool L_0;
		L_0 = Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567(/*hidden argument*/NULL);
		V_0 = L_0;
		bool L_1 = V_0;
		if (!L_1)
		{
			goto IL_0013;
		}
	}
	{
		// Destroy(toDelete);
		Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * L_2 = ___toDelete0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_Destroy_m3EEDB6ECD49A541EC826EA8E1C8B599F7AF67D30(L_2, /*hidden argument*/NULL);
		goto IL_001a;
	}

IL_0013:
	{
		// DestroyImmediate(toDelete);
		Object_tF2F3778131EFF286AF62B7B013A170F95A91571A * L_3 = ___toDelete0;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		Object_DestroyImmediate_mCCED69F4D4C9A4FA3AC30A142CF3D7F085F7C422(L_3, /*hidden argument*/NULL);
	}

IL_001a:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_Reset_mB8BDE292227F175942EF56E4B2D4573791E12016 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD8347DCBE5FCE9446D4005E07B9CA4B89E60F274_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_AddRange_mDF67379D637615B296F87C41C4777E4287062577_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// m_VisualEffect = GetComponent<VisualEffect>();
		VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * L_0;
		L_0 = Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5(__this, /*hidden argument*/Component_GetComponent_TisVisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA_m4F774DD3CE80343B108FC498DE927ED22B1FA2D5_RuntimeMethod_var);
		__this->set_m_VisualEffect_6(L_0);
		// m_Bindings = new List<VFXBinderBase>();
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_1 = (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *)il2cpp_codegen_object_new(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_il2cpp_TypeInfo_var);
		List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84(L_1, /*hidden argument*/List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84_RuntimeMethod_var);
		__this->set_m_Bindings_5(L_1);
		// m_Bindings.AddRange(gameObject.GetComponents<VFXBinderBase>());
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_2 = __this->get_m_Bindings_5();
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_3;
		L_3 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_3);
		VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* L_4;
		L_4 = GameObject_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD8347DCBE5FCE9446D4005E07B9CA4B89E60F274(L_3, /*hidden argument*/GameObject_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD8347DCBE5FCE9446D4005E07B9CA4B89E60F274_RuntimeMethod_var);
		NullCheck(L_2);
		List_1_AddRange_mDF67379D637615B296F87C41C4777E4287062577(L_2, (RuntimeObject*)(RuntimeObject*)L_4, /*hidden argument*/List_1_AddRange_mDF67379D637615B296F87C41C4777E4287062577_RuntimeMethod_var);
		// ClearPropertyBinders();
		VFXPropertyBinder_ClearPropertyBinders_m91FE331E06DB03867E665CF1C8AEB23389C1C835(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::LateUpdate()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_LateUpdate_mD3D19ED4160D35539C566387C3472B8124BAC802 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_m35A71CA7B83D420724389D4EFCBDE693EF4385FE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_mB9501A53AA026CCD393ECEB536029F9D5EB44A99_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral68E5CEC31382AB192FF06E62F708EC196A878699);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t V_1 = 0;
	VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * V_2 = NULL;
	bool V_3 = false;
	bool V_4 = false;
	bool V_5 = false;
	int32_t G_B4_0 = 0;
	{
		// if (!m_ExecuteInEditor && Application.isEditor && !Application.isPlaying) return;
		bool L_0 = __this->get_m_ExecuteInEditor_4();
		if (L_0)
		{
			goto IL_001a;
		}
	}
	{
		bool L_1;
		L_1 = Application_get_isEditor_m7367DDB72F13E4846E8EB76FFAAACA84840BE921(/*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_001a;
		}
	}
	{
		bool L_2;
		L_2 = Application_get_isPlaying_m7BB718D8E58B807184491F64AFF0649517E56567(/*hidden argument*/NULL);
		G_B4_0 = ((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_001b;
	}

IL_001a:
	{
		G_B4_0 = 0;
	}

IL_001b:
	{
		V_0 = (bool)G_B4_0;
		bool L_3 = V_0;
		if (!L_3)
		{
			goto IL_0021;
		}
	}
	{
		// if (!m_ExecuteInEditor && Application.isEditor && !Application.isPlaying) return;
		goto IL_009c;
	}

IL_0021:
	{
		// for (int i = 0; i < m_Bindings.Count; i++)
		V_1 = 0;
		goto IL_0088;
	}

IL_0025:
	{
		// var binding = m_Bindings[i];
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_4 = __this->get_m_Bindings_5();
		int32_t L_5 = V_1;
		NullCheck(L_4);
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_6;
		L_6 = List_1_get_Item_mB9501A53AA026CCD393ECEB536029F9D5EB44A99_inline(L_4, L_5, /*hidden argument*/List_1_get_Item_mB9501A53AA026CCD393ECEB536029F9D5EB44A99_RuntimeMethod_var);
		V_2 = L_6;
		// if (binding == null)
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_7 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_8;
		L_8 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_7, (Object_tF2F3778131EFF286AF62B7B013A170F95A91571A *)NULL, /*hidden argument*/NULL);
		V_3 = L_8;
		bool L_9 = V_3;
		if (!L_9)
		{
			goto IL_0062;
		}
	}
	{
		// Debug.LogWarning(string.Format("Parameter binder at index {0} of GameObject {1} is null or missing", i, gameObject.name));
		int32_t L_10 = V_1;
		int32_t L_11 = L_10;
		RuntimeObject * L_12 = Box(Int32_tFDE5F8CD43D10453F6A2E0C77FE48C6CC7009046_il2cpp_TypeInfo_var, &L_11);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_13;
		L_13 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		NullCheck(L_13);
		String_t* L_14;
		L_14 = Object_get_name_m0C7BC870ED2F0DC5A2FB09628136CD7D1CB82CFB(L_13, /*hidden argument*/NULL);
		String_t* L_15;
		L_15 = String_Format_m8D1CB0410C35E052A53AE957C914C841E54BAB66(_stringLiteral68E5CEC31382AB192FF06E62F708EC196A878699, L_12, L_14, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Debug_tEB68BCBEB8EFD60F8043C67146DC05E7F50F374B_il2cpp_TypeInfo_var);
		Debug_LogWarning_m24085D883C9E74D7AB423F0625E13259923960E7(L_15, /*hidden argument*/NULL);
		// continue;
		goto IL_0084;
	}

IL_0062:
	{
		// if (binding.IsValid(m_VisualEffect))
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_16 = V_2;
		VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * L_17 = __this->get_m_VisualEffect_6();
		NullCheck(L_16);
		bool L_18;
		L_18 = VirtFuncInvoker1< bool, VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * >::Invoke(4 /* System.Boolean UnityEngine.VFX.Utility.VFXBinderBase::IsValid(UnityEngine.VFX.VisualEffect) */, L_16, L_17);
		V_4 = L_18;
		bool L_19 = V_4;
		if (!L_19)
		{
			goto IL_0082;
		}
	}
	{
		// binding.UpdateBinding(m_VisualEffect);
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_20 = V_2;
		VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * L_21 = __this->get_m_VisualEffect_6();
		NullCheck(L_20);
		VirtActionInvoker1< VisualEffect_t7C6E2AAA4DB4F47960AF2029EA96D4B579B3A4CA * >::Invoke(9 /* System.Void UnityEngine.VFX.Utility.VFXBinderBase::UpdateBinding(UnityEngine.VFX.VisualEffect) */, L_20, L_21);
	}

IL_0082:
	{
	}

IL_0084:
	{
		// for (int i = 0; i < m_Bindings.Count; i++)
		int32_t L_22 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_22, (int32_t)1));
	}

IL_0088:
	{
		// for (int i = 0; i < m_Bindings.Count; i++)
		int32_t L_23 = V_1;
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_24 = __this->get_m_Bindings_5();
		NullCheck(L_24);
		int32_t L_25;
		L_25 = List_1_get_Count_m35A71CA7B83D420724389D4EFCBDE693EF4385FE_inline(L_24, /*hidden argument*/List_1_get_Count_m35A71CA7B83D420724389D4EFCBDE693EF4385FE_RuntimeMethod_var);
		V_5 = (bool)((((int32_t)L_23) < ((int32_t)L_25))? 1 : 0);
		bool L_26 = V_5;
		if (L_26)
		{
			goto IL_0025;
		}
	}

IL_009c:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::ClearPropertyBinders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_ClearPropertyBinders_m91FE331E06DB03867E665CF1C8AEB23389C1C835 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD763AD49B154A8E0EC3DAD23F489B74FF58AC680_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* V_0 = NULL;
	VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* V_1 = NULL;
	int32_t V_2 = 0;
	VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * V_3 = NULL;
	{
		// var allBinders = GetComponents<VFXBinderBase>();
		VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* L_0;
		L_0 = Component_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD763AD49B154A8E0EC3DAD23F489B74FF58AC680(__this, /*hidden argument*/Component_GetComponents_TisVFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD_mD763AD49B154A8E0EC3DAD23F489B74FF58AC680_RuntimeMethod_var);
		V_0 = L_0;
		// foreach (var binder in allBinders)
		VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* L_1 = V_0;
		V_1 = L_1;
		V_2 = 0;
		goto IL_001e;
	}

IL_000f:
	{
		// foreach (var binder in allBinders)
		VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* L_2 = V_1;
		int32_t L_3 = V_2;
		NullCheck(L_2);
		int32_t L_4 = L_3;
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_5 = (L_2)->GetAt(static_cast<il2cpp_array_size_t>(L_4));
		V_3 = L_5;
		// SafeDestroy(binder);
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_6 = V_3;
		VFXPropertyBinder_SafeDestroy_m761D308BA1CF96173734C0D0B7BBD2340B2FA4BE(L_6, /*hidden argument*/NULL);
		int32_t L_7 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add((int32_t)L_7, (int32_t)1));
	}

IL_001e:
	{
		// foreach (var binder in allBinders)
		int32_t L_8 = V_2;
		VFXBinderBaseU5BU5D_t3FB304042070D8FB742EEE18DB0AE3707E779780* L_9 = V_1;
		NullCheck(L_9);
		if ((((int32_t)L_8) < ((int32_t)((int32_t)((int32_t)(((RuntimeArray*)L_9)->max_length))))))
		{
			goto IL_000f;
		}
	}
	{
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::ClearParameterBinders()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_ClearParameterBinders_m3E6A93D2F762223A1CBC71902B0BE5EF6C20C670 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method)
{
	{
		// ClearPropertyBinders();
		VFXPropertyBinder_ClearPropertyBinders_m91FE331E06DB03867E665CF1C8AEB23389C1C835(__this, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::RemovePropertyBinder(UnityEngine.VFX.Utility.VFXBinderBase)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_RemovePropertyBinder_mBC7CE43AE8684F2E0FB16975264A14439D47E013 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * ___binder0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// if (binder.gameObject == this.gameObject)
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_0 = ___binder0;
		NullCheck(L_0);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_1;
		L_1 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(L_0, /*hidden argument*/NULL);
		GameObject_tC000A2E1A7CF1E10FD7BA08863287C072207C319 * L_2;
		L_2 = Component_get_gameObject_m55DC35B149AFB9157582755383BA954655FE0C5B(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Object_tF2F3778131EFF286AF62B7B013A170F95A91571A_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Equality_mEE9EC7EB5C7DC3E95B94AB904E1986FC4D566D54(L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		bool L_4 = V_0;
		if (!L_4)
		{
			goto IL_001d;
		}
	}
	{
		// SafeDestroy(binder);
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_5 = ___binder0;
		VFXPropertyBinder_SafeDestroy_m761D308BA1CF96173734C0D0B7BBD2340B2FA4BE(L_5, /*hidden argument*/NULL);
	}

IL_001d:
	{
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::RemoveParameterBinder(UnityEngine.VFX.Utility.VFXBinderBase)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder_RemoveParameterBinder_m19E203D779AC184AFE4E13759CD448B682C91D39 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * ___binder0, const RuntimeMethod* method)
{
	{
		// RemovePropertyBinder(binder);
		VFXBinderBase_t4E7B86F5FA583E3372139BE1AF6A2AAC1C06C4AD * L_0 = ___binder0;
		VFXPropertyBinder_RemovePropertyBinder_mBC7CE43AE8684F2E0FB16975264A14439D47E013(__this, L_0, /*hidden argument*/NULL);
		// }
		return;
	}
}
// System.Void UnityEngine.VFX.Utility.VFXPropertyBinder::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBinder__ctor_m3B41851C5943E5275DE7F0A8292743EC77E3C8B3 (VFXPropertyBinder_tEED91FE8D025822F0D2E4A5145CE1E10821B2F7F * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// protected bool m_ExecuteInEditor = true;
		__this->set_m_ExecuteInEditor_4((bool)1);
		// public List<VFXBinderBase> m_Bindings = new List<VFXBinderBase>();
		List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 * L_0 = (List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802 *)il2cpp_codegen_object_new(List_1_t91DD73665E6BF8A9D235DD5C3F76A503184A1802_il2cpp_TypeInfo_var);
		List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84(L_0, /*hidden argument*/List_1__ctor_m2FAEC0BD3669FAC32ED8E5A1E1E2725A1D716F84_RuntimeMethod_var);
		__this->set_m_Bindings_5(L_0);
		MonoBehaviour__ctor_mC0995D847F6A95B1A553652636C38A2AA8B13BED(__this, /*hidden argument*/NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.VFX.Utility.VFXPropertyBindingAttribute::.ctor(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void VFXPropertyBindingAttribute__ctor_mDB428901ACE003226B9BF70031743E8D0ED13C1B (VFXPropertyBindingAttribute_tE6A3A10164586DB90FCBCFE549DAE3EE1DB69684 * __this, StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* ___editorTypes0, const RuntimeMethod* method)
{
	{
		// public VFXPropertyBindingAttribute(params string[] editorTypes)
		PropertyAttribute__ctor_mA13181D93341AEAE429F0615989CB4647F2EB8A7(__this, /*hidden argument*/NULL);
		// EditorTypes = editorTypes;
		StringU5BU5D_tACEBFEDE350025B554CD507C9AE8FFE49359549A* L_0 = ___editorTypes0;
		__this->set_EditorTypes_0(L_0);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR RuntimeObject * List_1_get_Item_mF00B574E58FB078BB753B05A3B86DD0A7A266B63_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___index0;
		int32_t L_1 = (int32_t)__this->get__size_2();
		if ((!(((uint32_t)L_0) >= ((uint32_t)L_1))))
		{
			goto IL_000e;
		}
	}
	{
		ThrowHelper_ThrowArgumentOutOfRangeException_m4841366ABC2B2AFA37C10900551D7E07522C0929(/*hidden argument*/NULL);
	}

IL_000e:
	{
		ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE* L_2 = (ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)__this->get__items_1();
		int32_t L_3 = ___index0;
		RuntimeObject * L_4;
		L_4 = IL2CPP_ARRAY_UNSAFE_LOAD((ObjectU5BU5D_tC1F4EE0DB0B7300255F5FD4AF64FE4C585CF5ADE*)L_2, (int32_t)L_3);
		return (RuntimeObject *)L_4;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m5D847939ABB9A78203B062CAFFE975792174D00F_gshared_inline (List_1_t3F94120C77410A62EAE48421CF166B83AB95A2F5 * __this, const RuntimeMethod* method)
{
	{
		int32_t L_0 = (int32_t)__this->get__size_2();
		return (int32_t)L_0;
	}
}
