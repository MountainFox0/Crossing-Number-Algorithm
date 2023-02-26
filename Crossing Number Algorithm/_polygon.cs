namespace Crossing_Number_Algorithm
{
    //class _v
    //{
    //    private int x = 0;
    //    private int y = 0;
    //}


    //class init_polygon
    //{
    //    static void Main()
    //    {
    //        _polygon polygon;
    //        polygon = new _polygon();
    //        polygon.v.push(100, 200);
    //        Console.WriteLine(polygon.v[0]);
    //    }
    //}

    //var _polygon = function(){
    //        this.v = new Array();
    //    };
    //var polygon = new _polygon();
    //var v = function(x, y){
    //        this.x = x;
    //        this.y = y;
    //    };
    //public function init_polygon()
    //{
    //    polygon.v.push(new v(100, 100));
    //    polygon.v.push(new v(200, 500));
    //    polygon.v.push(new v(600, 500));
    //    polygon.v.push(new v(700, 100));
    //    polygon.v.push(new v(400, 300));
    //    polygon.v.push(new v(100, 100));
    //}
    //var _point = function(x, y){
    //        this.x = x;
    //this.y = y;
    //    }
    //    var point = new _point(300, 400);
    //function cn()
    //{
    //    cn = 0;
    //    for (i = 0; i < poly.v.length - 1; i++)
    //    {
    //        // 上向きの辺。点Pがy軸方向について、始点と終点の間にある。ただし、終点は含まない。(ルール1)
    //        if (((polygon.v[i].y <= point.y) && (polygon.v[i + 1].y > point.y))
    //            // 下向きの辺。点Pがy軸方向について、始点と終点の間にある。ただし、始点は含まない。(ルール2)
    //            || ((polygon.v[i].y > point.y) && (polygon.v[i + 1].y <= point.y)))
    //        {
    //            // ルール1,ルール2を確認することで、ルール3も確認できている。
    //            // 辺は点pよりも右側にある。ただし、重ならない。(ルール4)
    //            // 辺が点pと同じ高さになる位置を特定し、その時のxの値と点pのxの値を比較する。
    //            vt = (point.y - polygon.v[i].y) / (polygon.v[i + 1].y - polygon.v[i].y);
    //            if (point.x < (polygon.v[i].x + (vt * (polygon.v[i + 1].x - polygon.v[i].x))))
    //            {
    //                ++cn;
    //            }
    //        }
    //    }
    //}

}
