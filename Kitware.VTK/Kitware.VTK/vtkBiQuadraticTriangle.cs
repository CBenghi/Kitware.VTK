using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBiQuadraticTriangle : vtkNonLinearCell
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBiQuadraticTriangle";

		public new static readonly string MRClassNameKey;

		static vtkBiQuadraticTriangle()
		{
			vtkBiQuadraticTriangle.MRClassNameKey = "class vtkBiQuadraticTriangle";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBiQuadraticTriangle.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBiQuadraticTriangle"));
		}

		public vtkBiQuadraticTriangle(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticTriangle_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiQuadraticTriangle New()
		{
			vtkBiQuadraticTriangle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBiQuadraticTriangle() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_CellBoundary_01(HandleRef pThis, int subId, IntPtr pcoords, HandleRef pts);

		public override int CellBoundary(int subId, IntPtr pcoords, vtkIdList pts)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_CellBoundary_01(base.GetCppThis(), subId, pcoords, (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_Clip_02(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd, int insideOut);

		public override void Clip(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd, int insideOut)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Clip_02(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis(), insideOut);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_Contour_03(HandleRef pThis, double value, HandleRef cellScalars, HandleRef locator, HandleRef verts, HandleRef lines, HandleRef polys, HandleRef inPd, HandleRef outPd, HandleRef inCd, long cellId, HandleRef outCd);

		public override void Contour(double value, vtkDataArray cellScalars, vtkIncrementalPointLocator locator, vtkCellArray verts, vtkCellArray lines, vtkCellArray polys, vtkPointData inPd, vtkPointData outPd, vtkCellData inCd, long cellId, vtkCellData outCd)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Contour_03(base.GetCppThis(), value, (cellScalars == null) ? default(HandleRef) : cellScalars.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis(), (verts == null) ? default(HandleRef) : verts.GetCppThis(), (lines == null) ? default(HandleRef) : lines.GetCppThis(), (polys == null) ? default(HandleRef) : polys.GetCppThis(), (inPd == null) ? default(HandleRef) : inPd.GetCppThis(), (outPd == null) ? default(HandleRef) : outPd.GetCppThis(), (inCd == null) ? default(HandleRef) : inCd.GetCppThis(), cellId, (outCd == null) ? default(HandleRef) : outCd.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_Derivatives_04(HandleRef pThis, int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs);

		public override void Derivatives(int subId, IntPtr pcoords, IntPtr values, int dim, IntPtr derivs)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Derivatives_04(base.GetCppThis(), subId, pcoords, values, dim, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_EvaluateLocation_05(HandleRef pThis, ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights);

		public override void EvaluateLocation(ref int subId, IntPtr pcoords, IntPtr x, IntPtr weights)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_EvaluateLocation_05(base.GetCppThis(), ref subId, pcoords, x, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_EvaluatePosition_06(HandleRef pThis, IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights);

		public override int EvaluatePosition(IntPtr x, IntPtr closestPoint, ref int subId, IntPtr pcoords, ref double dist2, IntPtr weights)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_EvaluatePosition_06(base.GetCppThis(), x, closestPoint, ref subId, pcoords, ref dist2, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_GetCellDimension_07(HandleRef pThis);

		public override int GetCellDimension()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetCellDimension_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_GetCellType_08(HandleRef pThis);

		public override int GetCellType()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetCellType_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticTriangle_GetEdge_09(HandleRef pThis, int edgeId, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetEdge(int edgeId)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetEdge_09(base.GetCppThis(), edgeId, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticTriangle_GetFace_10(HandleRef pThis, int arg0, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public override vtkCell GetFace(int arg0)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetFace_10(base.GetCppThis(), arg0, ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_GetNumberOfEdges_11(HandleRef pThis);

		public override int GetNumberOfEdges()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetNumberOfEdges_11(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_GetNumberOfFaces_12(HandleRef pThis);

		public override int GetNumberOfFaces()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetNumberOfFaces_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_GetParametricCenter_13(HandleRef pThis, IntPtr pcoords);

		public override int GetParametricCenter(IntPtr pcoords)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetParametricCenter_13(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticTriangle_GetParametricCoords_14(HandleRef pThis);

		public override IntPtr GetParametricCoords()
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetParametricCoords_14(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern double vtkBiQuadraticTriangle_GetParametricDistance_15(HandleRef pThis, IntPtr pcoords);

		public override double GetParametricDistance(IntPtr pcoords)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_GetParametricDistance_15(base.GetCppThis(), pcoords);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_InterpolateDerivs_16(HandleRef pThis, IntPtr pcoords, IntPtr derivs);

		public override void InterpolateDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolateDerivs_16(base.GetCppThis(), pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_InterpolateFunctions_17(HandleRef pThis, IntPtr pcoords, IntPtr weights);

		public override void InterpolateFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolateFunctions_17(base.GetCppThis(), pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_InterpolationDerivs_18(IntPtr pcoords, IntPtr derivs);

		public static void InterpolationDerivs(IntPtr pcoords, IntPtr derivs)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolationDerivs_18(pcoords, derivs);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern void vtkBiQuadraticTriangle_InterpolationFunctions_19(IntPtr pcoords, IntPtr weights);

		public static void InterpolationFunctions(IntPtr pcoords, IntPtr weights)
		{
			vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_InterpolationFunctions_19(pcoords, weights);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_IntersectWithLine_20(HandleRef pThis, IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId);

		public override int IntersectWithLine(IntPtr p1, IntPtr p2, double tol, ref double t, IntPtr x, IntPtr pcoords, ref int subId)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_IntersectWithLine_20(base.GetCppThis(), p1, p2, tol, ref t, x, pcoords, ref subId);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_IsA_21(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_IsA_21(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_IsTypeOf_22(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_IsTypeOf_22(type);
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticTriangle_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBiQuadraticTriangle NewInstance()
		{
			vtkBiQuadraticTriangle result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_NewInstance_24(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBiQuadraticTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern IntPtr vtkBiQuadraticTriangle_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBiQuadraticTriangle SafeDownCast(vtkObjectBase o)
		{
			vtkBiQuadraticTriangle vtkBiQuadraticTriangle = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_SafeDownCast_25((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBiQuadraticTriangle = (vtkBiQuadraticTriangle)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBiQuadraticTriangle.Register(null);
				}
			}
			return vtkBiQuadraticTriangle;
		}

		[DllImport("Kitware.VTK.vtkFiltering.Unmanaged.dll")]
		internal static extern int vtkBiQuadraticTriangle_Triangulate_26(HandleRef pThis, int index, HandleRef ptIds, HandleRef pts);

		public override int Triangulate(int index, vtkIdList ptIds, vtkPoints pts)
		{
			return vtkBiQuadraticTriangle.vtkBiQuadraticTriangle_Triangulate_26(base.GetCppThis(), index, (ptIds == null) ? default(HandleRef) : ptIds.GetCppThis(), (pts == null) ? default(HandleRef) : pts.GetCppThis());
		}
	}
}
