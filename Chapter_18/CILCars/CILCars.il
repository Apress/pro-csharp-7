// Reference mscorlib.dll and
// System.Windows.Forms.dll.
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}
.assembly extern System.Windows.Forms
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 4:0:0:0
}
 
// Define the single-file assembly.
.assembly CILCars
{
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module CILCars.dll

// Implementation of CILCars.CILCar type.
.namespace CILCars
{
  .class public auto ansi beforefieldinit CILCar
    extends [mscorlib]System.Object
  {
    // The field data of the CILCar.
    .field public string petName
    .field public int32 currSpeed

    // The custom constructor simply allows the caller
    // to assign the field data.
    .method public hidebysig specialname rtspecialname
    instance void .ctor(int32 c, string p) cil managed
    {
    .maxstack 8

    // Load first arg onto the stack and call base class ctor.
    ldarg.0 // "this" object, not the int32!
    call instance void [mscorlib]System.Object::.ctor()

    // Now load first and second args onto the stack.
    ldarg.0 // "this" object
    ldarg.1 // int32 arg

    // Store topmost stack (int 32) member in currSpeed field.
    stfld int32 CILCars.CILCar::currSpeed

    // Load string arg and store in petName field.
    ldarg.0 // "this" object
    ldarg.2 // string arg
    stfld string CILCars.CILCar::petName
    ret
  }
 }

.class public auto ansi beforefieldinit CILCarInfo
  extends [mscorlib]System.Object
{
  .method public hidebysig static void
    Display(class CILCars.CILCar c) cil managed
  {
    .maxstack 8

    // We need a local string variable.
    .locals init ([0] string caption)

    // Load string and the incoming CILCar onto the stack.
    ldstr "{0}'s speed is:"
    ldarg.0

    // Now place the value of the CILCar's petName on the
    // stack and call the static String.Format() method.
    ldfld string CILCars.CILCar::petName
    call string [mscorlib]System.String::Format(string, object)
    stloc.0

    // Now load the value of the currSpeed field and get its string
    // representation (note call to ToString()).
    ldarg.0
    ldflda int32 CILCars.CILCar::currSpeed
    call instance string [mscorlib]System.Int32::ToString()
    ldloc.0

    // Now call the MessageBox.Show() method with loaded values.
    call valuetype [System.Windows.Forms]
        System.Windows.Forms.DialogResult
        [System.Windows.Forms]
        System.Windows.Forms.MessageBox::Show(string, string)
    pop
    ret
  }
}

}
