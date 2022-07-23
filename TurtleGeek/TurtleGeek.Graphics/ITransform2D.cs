using System;
using System.Drawing;

namespace TurtleGeek.Graphics
{

	/// <summary>
	/// This interface is useful in the Plot classes for transforming 
	/// world to physical coordinates. Create on using the GetTransformer
	/// static method in Transform2D.
	/// </summary>
	public interface ITransform2D
	{

		/// <summary>
		/// Transforms the given world point to physical coordinates
		/// </summary>
		PointF Transform( double x, double y );

		/// <summary>
		/// Transforms the given world point to physical coordinates
		/// </summary>
		PointF Transform( PointD worldPoint );

	}

}
