﻿using System;
using System.Collections.Generic;
using System.Text;
using NumSharp.Backends;

namespace NumSharp
{
    public static partial class np
    {
        public static NDArray ndarray(Shape shape, Type dtype = null, Array buffer = null, string order = "F")
            => BackendFactory.GetEngine().NDArray(shape, dtype: dtype, buffer: buffer, order: order);

        /// <summary>
        /// Roll array elements along a given axis.
        /// 
        /// Elements that roll beyond the last position are re-introduced at the first.
        /// </summary>
        public static int roll(NDArray nd, int shift, int axis = -1)
            => nd.roll(shift, axis);

        /// <summary>
        /// Return a contiguous flattened array.
        /// 
        /// A 1-D array, containing the elements of the input, is returned.A copy is made only if needed.
        /// </summary>
        public static NDArray ravel(NDArray a) 
            => a.ravel();

        public static NDArray transpose(NDArray x, int[] axes = null)
            => BackendFactory.GetEngine().Transpose(x, axes: axes);

        /// <summary>
        /// Find the unique elements of an array.
        /// 
        /// Returns the sorted unique elements of an array.There are three optional outputs in addition to the unique elements:
        /// * the indices of the input array that give the unique values
        /// * the indices of the unique array that reconstruct the input array
        /// * the number of times each unique value comes up in the input array
        /// </summary>
        public static NDArray unique<T>(NDArray a)
            => a.unique<T>();
    }
}
