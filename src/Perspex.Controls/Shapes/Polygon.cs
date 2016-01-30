﻿using Perspex.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perspex.Controls.Shapes
{
    public class Polygon : Shape
    {
        public static readonly StyledProperty<IList<Point>> PointsProperty =
            PerspexProperty.Register<Polygon, IList<Point>>("Points");

        public IList<Point> Points
        {
            get { return GetValue(PointsProperty); }
            set { SetValue(PointsProperty, value); }
        }

        public override Geometry DefiningGeometry => new PolylineGeometry(Points, true);
    }
}