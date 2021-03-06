using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPExtractArraysOverTime : vtkExtractArraysOverTime
	{
		public enum Tags
		{
			EXCHANGE_DATA = 1972
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkPExtractArraysOverTime";

		public new static readonly string MRClassNameKey;

		static vtkPExtractArraysOverTime()
		{
			vtkPExtractArraysOverTime.MRClassNameKey = "class vtkPExtractArraysOverTime";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExtractArraysOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExtractArraysOverTime"));
		}

		public vtkPExtractArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPExtractArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPExtractArraysOverTime New()
		{
			vtkPExtractArraysOverTime result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPExtractArraysOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPExtractArraysOverTime_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_GetController_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPExtractArraysOverTime_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkPExtractArraysOverTime_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPExtractArraysOverTime_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPExtractArraysOverTime NewInstance()
		{
			vtkPExtractArraysOverTime result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkPExtractArraysOverTime_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPExtractArraysOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkPExtractArraysOverTime vtkPExtractArraysOverTime = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExtractArraysOverTime = (vtkPExtractArraysOverTime)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExtractArraysOverTime.Register(null);
				}
			}
			return vtkPExtractArraysOverTime;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkPExtractArraysOverTime_SetController_07(HandleRef pThis, HandleRef arg0);

		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPExtractArraysOverTime.vtkPExtractArraysOverTime_SetController_07(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
