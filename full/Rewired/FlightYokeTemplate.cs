using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Rewired;

public sealed class FlightYokeTemplate : ControllerTemplate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rotateYoke;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_yokeZ;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPaddle;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPaddle;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5Axis;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5MinDetent;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_centerButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel1Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Up;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Down;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_wheel2Press;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatDownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHatUpLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatDownLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHatUpLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton6;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton7;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton8;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton9;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_consoleButton10;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_mode3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_yoke;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever1;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever2;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever3;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever4;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_lever5;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftGripHat;

	private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightGripHat;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

	public unsafe static Il2CppSystem.Guid typeGuid
	{
		get
		{
			Unsafe.SkipInit(out Il2CppSystem.Guid result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeGuid, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeGuid, (void*)(&guid));
		}
	}

	public unsafe static int elementId_rotateYoke
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rotateYoke, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rotateYoke, (void*)(&num));
		}
	}

	public unsafe static int elementId_yokeZ
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_yokeZ, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_yokeZ, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftPaddle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftPaddle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftPaddle, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightPaddle
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightPaddle, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightPaddle, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever1Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever1Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever1Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever1MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever1MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever1MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever2Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever2Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever2Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever2MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever2MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever2MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever3Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever3Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever3Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever3MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever3MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever3MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever4Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever4Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever4Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever4MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever4MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever4MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever5Axis
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever5Axis, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever5Axis, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever5MinDetent
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever5MinDetent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever5MinDetent, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_centerButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_centerButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_centerButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel1Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel1Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel1Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel1Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel1Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel1Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel1Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel1Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel1Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel2Up
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel2Up, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel2Up, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel2Down
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel2Down, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel2Down, (void*)(&num));
		}
	}

	public unsafe static int elementId_wheel2Press
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_wheel2Press, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_wheel2Press, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatUp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatUp, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatUpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatUpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatDownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatDownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatDown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatDown, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatDownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatDownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHatUpLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHatUpLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatUp
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatUp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatUp, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatUpRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatUpRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatDownRight
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatDownRight, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatDown
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatDown, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatDown, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatDownLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatDownLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHatUpLeft
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHatUpLeft, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton1, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton2, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton3, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton4, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton5, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton6
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton6, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton7
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton7, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton8
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton8, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton9
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton9, (void*)(&num));
		}
	}

	public unsafe static int elementId_consoleButton10
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_consoleButton10, (void*)(&num));
		}
	}

	public unsafe static int elementId_mode1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_mode1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_mode1, (void*)(&num));
		}
	}

	public unsafe static int elementId_mode2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_mode2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_mode2, (void*)(&num));
		}
	}

	public unsafe static int elementId_mode3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_mode3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_mode3, (void*)(&num));
		}
	}

	public unsafe static int elementId_yoke
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_yoke, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_yoke, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever1
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever1, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever1, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever2
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever2, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever2, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever3
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever3, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever3, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever4
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever4, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever4, (void*)(&num));
		}
	}

	public unsafe static int elementId_lever5
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_lever5, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_lever5, (void*)(&num));
		}
	}

	public unsafe static int elementId_leftGripHat
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_leftGripHat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_leftGripHat, (void*)(&num));
		}
	}

	public unsafe static int elementId_rightGripHat
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_elementId_rightGripHat, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_elementId_rightGripHat, (void*)(&num));
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftPaddle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710094, XrefRangeEnd = 710097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightPaddle
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710097, XrefRangeEnd = 710100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710100, XrefRangeEnd = 710103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710103, XrefRangeEnd = 710106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710106, XrefRangeEnd = 710109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710109, XrefRangeEnd = 710112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710112, XrefRangeEnd = 710115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EleftGripButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710115, XrefRangeEnd = 710118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710118, XrefRangeEnd = 710121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710121, XrefRangeEnd = 710124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710124, XrefRangeEnd = 710127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710127, XrefRangeEnd = 710130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710130, XrefRangeEnd = 710133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002ErightGripButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710133, XrefRangeEnd = 710136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710136, XrefRangeEnd = 710139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710139, XrefRangeEnd = 710142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710142, XrefRangeEnd = 710145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710145, XrefRangeEnd = 710148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710148, XrefRangeEnd = 710151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710151, XrefRangeEnd = 710154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710154, XrefRangeEnd = 710157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EcenterButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710157, XrefRangeEnd = 710160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Up
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710160, XrefRangeEnd = 710163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Down
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710163, XrefRangeEnd = 710166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel1Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710166, XrefRangeEnd = 710169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Up
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710169, XrefRangeEnd = 710172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Down
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710172, XrefRangeEnd = 710175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Ewheel2Press
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710175, XrefRangeEnd = 710178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710178, XrefRangeEnd = 710181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710181, XrefRangeEnd = 710184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710184, XrefRangeEnd = 710187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710187, XrefRangeEnd = 710190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710190, XrefRangeEnd = 710193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton6
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710193, XrefRangeEnd = 710196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton7
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710196, XrefRangeEnd = 710199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton8
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710199, XrefRangeEnd = 710202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton9
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710202, XrefRangeEnd = 710205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002EconsoleButton10
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710205, XrefRangeEnd = 710208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710208, XrefRangeEnd = 710211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710211, XrefRangeEnd = 710214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateButton Rewired_002EIFlightYokeTemplate_002Emode3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710214, XrefRangeEnd = 710217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateButton>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateYoke Rewired_002EIFlightYokeTemplate_002Eyoke
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710217, XrefRangeEnd = 710225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateYoke>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever1
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710225, XrefRangeEnd = 710228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever2
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710228, XrefRangeEnd = 710231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever3
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710231, XrefRangeEnd = 710234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever4
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710234, XrefRangeEnd = 710237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateThrottle Rewired_002EIFlightYokeTemplate_002Elever5
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710237, XrefRangeEnd = 710240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateThrottle>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002EleftGripHat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710240, XrefRangeEnd = 710243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	public unsafe virtual IControllerTemplateHat Rewired_002EIFlightYokeTemplate_002ErightGripHat
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 710243, XrefRangeEnd = 710246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr2);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IControllerTemplateHat>(intPtr) : null;
		}
	}

	static FlightYokeTemplate()
	{
		Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", "FlightYokeTemplate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr);
		NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "typeGuid");
		NativeFieldInfoPtr_elementId_rotateYoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rotateYoke");
		NativeFieldInfoPtr_elementId_yokeZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_yokeZ");
		NativeFieldInfoPtr_elementId_leftPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftPaddle");
		NativeFieldInfoPtr_elementId_rightPaddle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightPaddle");
		NativeFieldInfoPtr_elementId_lever1Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1Axis");
		NativeFieldInfoPtr_elementId_lever1MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1MinDetent");
		NativeFieldInfoPtr_elementId_lever2Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2Axis");
		NativeFieldInfoPtr_elementId_lever2MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2MinDetent");
		NativeFieldInfoPtr_elementId_lever3Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3Axis");
		NativeFieldInfoPtr_elementId_lever3MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3MinDetent");
		NativeFieldInfoPtr_elementId_lever4Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4Axis");
		NativeFieldInfoPtr_elementId_lever4MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4MinDetent");
		NativeFieldInfoPtr_elementId_lever5Axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5Axis");
		NativeFieldInfoPtr_elementId_lever5MinDetent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5MinDetent");
		NativeFieldInfoPtr_elementId_leftGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton1");
		NativeFieldInfoPtr_elementId_leftGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton2");
		NativeFieldInfoPtr_elementId_leftGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton3");
		NativeFieldInfoPtr_elementId_leftGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton4");
		NativeFieldInfoPtr_elementId_leftGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton5");
		NativeFieldInfoPtr_elementId_leftGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripButton6");
		NativeFieldInfoPtr_elementId_rightGripButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton1");
		NativeFieldInfoPtr_elementId_rightGripButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton2");
		NativeFieldInfoPtr_elementId_rightGripButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton3");
		NativeFieldInfoPtr_elementId_rightGripButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton4");
		NativeFieldInfoPtr_elementId_rightGripButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton5");
		NativeFieldInfoPtr_elementId_rightGripButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripButton6");
		NativeFieldInfoPtr_elementId_centerButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton1");
		NativeFieldInfoPtr_elementId_centerButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton2");
		NativeFieldInfoPtr_elementId_centerButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton3");
		NativeFieldInfoPtr_elementId_centerButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton4");
		NativeFieldInfoPtr_elementId_centerButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton5");
		NativeFieldInfoPtr_elementId_centerButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton6");
		NativeFieldInfoPtr_elementId_centerButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton7");
		NativeFieldInfoPtr_elementId_centerButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_centerButton8");
		NativeFieldInfoPtr_elementId_wheel1Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Up");
		NativeFieldInfoPtr_elementId_wheel1Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Down");
		NativeFieldInfoPtr_elementId_wheel1Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel1Press");
		NativeFieldInfoPtr_elementId_wheel2Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Up");
		NativeFieldInfoPtr_elementId_wheel2Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Down");
		NativeFieldInfoPtr_elementId_wheel2Press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_wheel2Press");
		NativeFieldInfoPtr_elementId_leftGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUp");
		NativeFieldInfoPtr_elementId_leftGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUpRight");
		NativeFieldInfoPtr_elementId_leftGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatRight");
		NativeFieldInfoPtr_elementId_leftGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDownRight");
		NativeFieldInfoPtr_elementId_leftGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDown");
		NativeFieldInfoPtr_elementId_leftGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatDownLeft");
		NativeFieldInfoPtr_elementId_leftGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatLeft");
		NativeFieldInfoPtr_elementId_leftGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHatUpLeft");
		NativeFieldInfoPtr_elementId_rightGripHatUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUp");
		NativeFieldInfoPtr_elementId_rightGripHatUpRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUpRight");
		NativeFieldInfoPtr_elementId_rightGripHatRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatRight");
		NativeFieldInfoPtr_elementId_rightGripHatDownRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDownRight");
		NativeFieldInfoPtr_elementId_rightGripHatDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDown");
		NativeFieldInfoPtr_elementId_rightGripHatDownLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatDownLeft");
		NativeFieldInfoPtr_elementId_rightGripHatLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatLeft");
		NativeFieldInfoPtr_elementId_rightGripHatUpLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHatUpLeft");
		NativeFieldInfoPtr_elementId_consoleButton1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton1");
		NativeFieldInfoPtr_elementId_consoleButton2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton2");
		NativeFieldInfoPtr_elementId_consoleButton3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton3");
		NativeFieldInfoPtr_elementId_consoleButton4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton4");
		NativeFieldInfoPtr_elementId_consoleButton5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton5");
		NativeFieldInfoPtr_elementId_consoleButton6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton6");
		NativeFieldInfoPtr_elementId_consoleButton7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton7");
		NativeFieldInfoPtr_elementId_consoleButton8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton8");
		NativeFieldInfoPtr_elementId_consoleButton9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton9");
		NativeFieldInfoPtr_elementId_consoleButton10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_consoleButton10");
		NativeFieldInfoPtr_elementId_mode1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode1");
		NativeFieldInfoPtr_elementId_mode2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode2");
		NativeFieldInfoPtr_elementId_mode3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_mode3");
		NativeFieldInfoPtr_elementId_yoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_yoke");
		NativeFieldInfoPtr_elementId_lever1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever1");
		NativeFieldInfoPtr_elementId_lever2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever2");
		NativeFieldInfoPtr_elementId_lever3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever3");
		NativeFieldInfoPtr_elementId_lever4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever4");
		NativeFieldInfoPtr_elementId_lever5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_lever5");
		NativeFieldInfoPtr_elementId_leftGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_leftGripHat");
		NativeFieldInfoPtr_elementId_rightGripHat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, "elementId_rightGripHat");
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666060);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightPaddle_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666061);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666062);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666063);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666064);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666065);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666066);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666067);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666068);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666069);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666070);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666071);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666072);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666073);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666074);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666075);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666076);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666077);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666078);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666079);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666080);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_centerButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666081);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666082);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666083);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel1Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666084);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Up_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666085);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Down_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666086);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_wheel2Press_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666087);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666088);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666089);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666090);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton4_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666091);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton5_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666092);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton6_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666093);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton7_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666094);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton8_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666095);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton9_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666096);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_consoleButton10_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666097);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode1_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666098);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode2_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666099);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_mode3_Private_Virtual_Final_New_get_IControllerTemplateButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666100);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_yoke_Private_Virtual_Final_New_get_IControllerTemplateYoke_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666101);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever1_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666102);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever2_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666103);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever3_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666104);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever4_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666105);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_lever5_Private_Virtual_Final_New_get_IControllerTemplateThrottle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666106);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_leftGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666107);
		NativeMethodInfoPtr_Rewired_IFlightYokeTemplate_get_rightGripHat_Private_Virtual_Final_New_get_IControllerTemplateHat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666108);
		NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr, 100666109);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 709688, RefRangeEnd = 709694, XrefRangeStart = 709688, XrefRangeEnd = 709694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlightYokeTemplate(Il2CppSystem.Object payload)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightYokeTemplate>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)payload);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	public FlightYokeTemplate(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
