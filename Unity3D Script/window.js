import System;
import System.Runtime.InteropServices;

@DllImportAttribute("user32.dll")
public  static function  ShowWindow(hwnd:IntPtr,nCmdShow:int):boolean{};

@DllImportAttribute("user32.dll")
public static function  GetForegroundWindow ():IntPtr{};  
      
@DllImportAttribute("user32.dll")
public static function  GetActiveWindow ():IntPtr{};  
 
function OnGUI () 
{
   ShowWindow(GetActiveWindow(),1);
}
