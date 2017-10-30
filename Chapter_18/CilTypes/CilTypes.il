// List of referenced assemblies.
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 2:0:0:0
}

// Our assembly
.assembly CILTypes
{
  .ver 1:0:0:0
}
// The module of our single-file assembly.
.module CILTypes.dll

// Our assembly has a single namespace.
.namespace MyNamespace
{
	// An interface definition.
    .class public interface IMyInterface {}
    
	.class public MyBaseClass 
	{
		// Some field data.
		.field private string stringField 
		.field private int32 intField	
		
		// A custom constructor.
		.method public hidebysig specialname rtspecialname 
			instance void .ctor(string s, int32 i) cil managed
		{
			// TODO: Add implementation code...		
		}

		// Property syntax.
		.method public hidebysig specialname 
		instance string get_TheString() cil managed
		{
			// TODO: Add implementation code...
		}  

		.method public hidebysig specialname 
		instance void set_TheString(string 'value') cil managed
		{
			// TODO: Add implementation code...
		}  

		.property instance string TheString()
		{
		.get instance string 
		  MyNamespace.MyBaseClass::get_TheString()
		.set instance void 
		  MyNamespace. MyBaseClass::set_TheString(string)
		}

	}     

    // MyDerivedClass now implements IAmAnInterface.
	.class public MyDerivedClass 
		extends MyNamespace.MyBaseClass
        implements MyNamespace.IMyInterface {}    
          
	// Shorthand notation for declaring a structure.
	.class public sealed value MyStruct{} 

	// Enum shorthand.
	.class public sealed enum MyEnum
	{
		.field public static literal valuetype 
		MyNamespace.MyEnum A = int32(0)
		.field public static literal valuetype 
		MyNamespace.MyEnum B = int32(1)
		.field public static literal valuetype 
		MyNamespace.MyEnum C = int32(2)	
	}     

	// A custom generic class with 1 type parameter. 
	.class public MyGenericClass`1<T>{}    
}


