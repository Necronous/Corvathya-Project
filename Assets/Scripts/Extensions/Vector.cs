using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector
{
    public static Vector2 Vec2(float f) => new(f, f);
    public static Vector2 Vec2(Vector3 v) => new(v.x, v.y);
    public static Vector2 Vec2(Vector4 v) => new(v.x, v.y);
    public static Vector3 Vec3(float f) => new(f, f, f);
    public static Vector3 Vec3(Vector2 v) => new(v.x, v.y);
    public static Vector3 Vec3(Vector4 v) => new(v.x, v.y);
    public static Vector4 Vec4(float f) => new(f, f, f, f);
    public static Vector4 Vec4(Vector2 v) => new(v.x, v.y);
    public static Vector4 Vec4(Vector3 v) => new(v.x, v.y);
    public static Vector2 Swizzle_xx(this Vector2 a) { return new Vector2(a.x, a.x); }
    public static Vector2 Swizzle_xy(this Vector2 a) { return new Vector2(a.x, a.y); }
    public static Vector2 Swizzle_x0(this Vector2 a) { return new Vector2(a.x, 0); }
    public static Vector2 Swizzle_x1(this Vector2 a) { return new Vector2(a.x, 1); }
    public static Vector2 Swizzle_yx(this Vector2 a) { return new Vector2(a.y, a.x); }
    public static Vector2 Swizzle_yy(this Vector2 a) { return new Vector2(a.y, a.y); }
    public static Vector2 Swizzle_y0(this Vector2 a) { return new Vector2(a.y, 0); }
    public static Vector2 Swizzle_y1(this Vector2 a) { return new Vector2(a.y, 1); }
    public static Vector2 Swizzle_0x(this Vector2 a) { return new Vector2(0, a.x); }
    public static Vector2 Swizzle_0y(this Vector2 a) { return new Vector2(0, a.y); }
    public static Vector2 Swizzle_00(this Vector2 a) { return new Vector2(0, 0); }
    public static Vector2 Swizzle_01(this Vector2 a) { return new Vector2(0, 1); }
    public static Vector2 Swizzle_1x(this Vector2 a) { return new Vector2(1, a.x); }
    public static Vector2 Swizzle_1y(this Vector2 a) { return new Vector2(1, a.y); }
    public static Vector2 Swizzle_10(this Vector2 a) { return new Vector2(1, 0); }
    public static Vector2 Swizzle_11(this Vector2 a) { return new Vector2(1, 1); }
    public static Vector3 Swizzle_xxx(this Vector2 a) { return new Vector3(a.x, a.x, a.x); }
    public static Vector3 Swizzle_xxy(this Vector2 a) { return new Vector3(a.x, a.x, a.y); }
    public static Vector3 Swizzle_xx0(this Vector2 a) { return new Vector3(a.x, a.x, 0); }
    public static Vector3 Swizzle_xx1(this Vector2 a) { return new Vector3(a.x, a.x, 1); }
    public static Vector3 Swizzle_xyx(this Vector2 a) { return new Vector3(a.x, a.y, a.x); }
    public static Vector3 Swizzle_xyy(this Vector2 a) { return new Vector3(a.x, a.y, a.y); }
    public static Vector3 Swizzle_xy0(this Vector2 a) { return new Vector3(a.x, a.y, 0); }
    public static Vector3 Swizzle_xy1(this Vector2 a) { return new Vector3(a.x, a.y, 1); }
    public static Vector3 Swizzle_x0x(this Vector2 a) { return new Vector3(a.x, 0, a.x); }
    public static Vector3 Swizzle_x0y(this Vector2 a) { return new Vector3(a.x, 0, a.y); }
    public static Vector3 Swizzle_x00(this Vector2 a) { return new Vector3(a.x, 0, 0); }
    public static Vector3 Swizzle_x01(this Vector2 a) { return new Vector3(a.x, 0, 1); }
    public static Vector3 Swizzle_x1x(this Vector2 a) { return new Vector3(a.x, 1, a.x); }
    public static Vector3 Swizzle_x1y(this Vector2 a) { return new Vector3(a.x, 1, a.y); }
    public static Vector3 Swizzle_x10(this Vector2 a) { return new Vector3(a.x, 1, 0); }
    public static Vector3 Swizzle_x11(this Vector2 a) { return new Vector3(a.x, 1, 1); }
    public static Vector3 Swizzle_yxx(this Vector2 a) { return new Vector3(a.y, a.x, a.x); }
    public static Vector3 Swizzle_yxy(this Vector2 a) { return new Vector3(a.y, a.x, a.y); }
    public static Vector3 Swizzle_yx0(this Vector2 a) { return new Vector3(a.y, a.x, 0); }
    public static Vector3 Swizzle_yx1(this Vector2 a) { return new Vector3(a.y, a.x, 1); }
    public static Vector3 Swizzle_yyx(this Vector2 a) { return new Vector3(a.y, a.y, a.x); }
    public static Vector3 Swizzle_yyy(this Vector2 a) { return new Vector3(a.y, a.y, a.y); }
    public static Vector3 Swizzle_yy0(this Vector2 a) { return new Vector3(a.y, a.y, 0); }
    public static Vector3 Swizzle_yy1(this Vector2 a) { return new Vector3(a.y, a.y, 1); }
    public static Vector3 Swizzle_y0x(this Vector2 a) { return new Vector3(a.y, 0, a.x); }
    public static Vector3 Swizzle_y0y(this Vector2 a) { return new Vector3(a.y, 0, a.y); }
    public static Vector3 Swizzle_y00(this Vector2 a) { return new Vector3(a.y, 0, 0); }
    public static Vector3 Swizzle_y01(this Vector2 a) { return new Vector3(a.y, 0, 1); }
    public static Vector3 Swizzle_y1x(this Vector2 a) { return new Vector3(a.y, 1, a.x); }
    public static Vector3 Swizzle_y1y(this Vector2 a) { return new Vector3(a.y, 1, a.y); }
    public static Vector3 Swizzle_y10(this Vector2 a) { return new Vector3(a.y, 1, 0); }
    public static Vector3 Swizzle_y11(this Vector2 a) { return new Vector3(a.y, 1, 1); }
    public static Vector3 Swizzle_0xx(this Vector2 a) { return new Vector3(0, a.x, a.x); }
    public static Vector3 Swizzle_0xy(this Vector2 a) { return new Vector3(0, a.x, a.y); }
    public static Vector3 Swizzle_0x0(this Vector2 a) { return new Vector3(0, a.x, 0); }
    public static Vector3 Swizzle_0x1(this Vector2 a) { return new Vector3(0, a.x, 1); }
    public static Vector3 Swizzle_0yx(this Vector2 a) { return new Vector3(0, a.y, a.x); }
    public static Vector3 Swizzle_0yy(this Vector2 a) { return new Vector3(0, a.y, a.y); }
    public static Vector3 Swizzle_0y0(this Vector2 a) { return new Vector3(0, a.y, 0); }
    public static Vector3 Swizzle_0y1(this Vector2 a) { return new Vector3(0, a.y, 1); }
    public static Vector3 Swizzle_00x(this Vector2 a) { return new Vector3(0, 0, a.x); }
    public static Vector3 Swizzle_00y(this Vector2 a) { return new Vector3(0, 0, a.y); }
    public static Vector3 Swizzle_000(this Vector2 a) { return new Vector3(0, 0, 0); }
    public static Vector3 Swizzle_001(this Vector2 a) { return new Vector3(0, 0, 1); }
    public static Vector3 Swizzle_01x(this Vector2 a) { return new Vector3(0, 1, a.x); }
    public static Vector3 Swizzle_01y(this Vector2 a) { return new Vector3(0, 1, a.y); }
    public static Vector3 Swizzle_010(this Vector2 a) { return new Vector3(0, 1, 0); }
    public static Vector3 Swizzle_011(this Vector2 a) { return new Vector3(0, 1, 1); }
    public static Vector3 Swizzle_1xx(this Vector2 a) { return new Vector3(1, a.x, a.x); }
    public static Vector3 Swizzle_1xy(this Vector2 a) { return new Vector3(1, a.x, a.y); }
    public static Vector3 Swizzle_1x0(this Vector2 a) { return new Vector3(1, a.x, 0); }
    public static Vector3 Swizzle_1x1(this Vector2 a) { return new Vector3(1, a.x, 1); }
    public static Vector3 Swizzle_1yx(this Vector2 a) { return new Vector3(1, a.y, a.x); }
    public static Vector3 Swizzle_1yy(this Vector2 a) { return new Vector3(1, a.y, a.y); }
    public static Vector3 Swizzle_1y0(this Vector2 a) { return new Vector3(1, a.y, 0); }
    public static Vector3 Swizzle_1y1(this Vector2 a) { return new Vector3(1, a.y, 1); }
    public static Vector3 Swizzle_10x(this Vector2 a) { return new Vector3(1, 0, a.x); }
    public static Vector3 Swizzle_10y(this Vector2 a) { return new Vector3(1, 0, a.y); }
    public static Vector3 Swizzle_100(this Vector2 a) { return new Vector3(1, 0, 0); }
    public static Vector3 Swizzle_101(this Vector2 a) { return new Vector3(1, 0, 1); }
    public static Vector3 Swizzle_11x(this Vector2 a) { return new Vector3(1, 1, a.x); }
    public static Vector3 Swizzle_11y(this Vector2 a) { return new Vector3(1, 1, a.y); }
    public static Vector3 Swizzle_110(this Vector2 a) { return new Vector3(1, 1, 0); }
    public static Vector3 Swizzle_111(this Vector2 a) { return new Vector3(1, 1, 1); }
    public static Vector4 Swizzle_xxxx(this Vector2 a) { return new Vector4(a.x, a.x, a.x, a.x); }
    public static Vector4 Swizzle_xxxy(this Vector2 a) { return new Vector4(a.x, a.x, a.x, a.y); }
    public static Vector4 Swizzle_xxx0(this Vector2 a) { return new Vector4(a.x, a.x, a.x, 0); }
    public static Vector4 Swizzle_xxx1(this Vector2 a) { return new Vector4(a.x, a.x, a.x, 1); }
    public static Vector4 Swizzle_xxyx(this Vector2 a) { return new Vector4(a.x, a.x, a.y, a.x); }
    public static Vector4 Swizzle_xxyy(this Vector2 a) { return new Vector4(a.x, a.x, a.y, a.y); }
    public static Vector4 Swizzle_xxy0(this Vector2 a) { return new Vector4(a.x, a.x, a.y, 0); }
    public static Vector4 Swizzle_xxy1(this Vector2 a) { return new Vector4(a.x, a.x, a.y, 1); }
    public static Vector4 Swizzle_xx0x(this Vector2 a) { return new Vector4(a.x, a.x, 0, a.x); }
    public static Vector4 Swizzle_xx0y(this Vector2 a) { return new Vector4(a.x, a.x, 0, a.y); }
    public static Vector4 Swizzle_xx00(this Vector2 a) { return new Vector4(a.x, a.x, 0, 0); }
    public static Vector4 Swizzle_xx01(this Vector2 a) { return new Vector4(a.x, a.x, 0, 1); }
    public static Vector4 Swizzle_xx1x(this Vector2 a) { return new Vector4(a.x, a.x, 1, a.x); }
    public static Vector4 Swizzle_xx1y(this Vector2 a) { return new Vector4(a.x, a.x, 1, a.y); }
    public static Vector4 Swizzle_xx10(this Vector2 a) { return new Vector4(a.x, a.x, 1, 0); }
    public static Vector4 Swizzle_xx11(this Vector2 a) { return new Vector4(a.x, a.x, 1, 1); }
    public static Vector4 Swizzle_xyxx(this Vector2 a) { return new Vector4(a.x, a.y, a.x, a.x); }
    public static Vector4 Swizzle_xyxy(this Vector2 a) { return new Vector4(a.x, a.y, a.x, a.y); }
    public static Vector4 Swizzle_xyx0(this Vector2 a) { return new Vector4(a.x, a.y, a.x, 0); }
    public static Vector4 Swizzle_xyx1(this Vector2 a) { return new Vector4(a.x, a.y, a.x, 1); }
    public static Vector4 Swizzle_xyyx(this Vector2 a) { return new Vector4(a.x, a.y, a.y, a.x); }
    public static Vector4 Swizzle_xyyy(this Vector2 a) { return new Vector4(a.x, a.y, a.y, a.y); }
    public static Vector4 Swizzle_xyy0(this Vector2 a) { return new Vector4(a.x, a.y, a.y, 0); }
    public static Vector4 Swizzle_xyy1(this Vector2 a) { return new Vector4(a.x, a.y, a.y, 1); }
    public static Vector4 Swizzle_xy0x(this Vector2 a) { return new Vector4(a.x, a.y, 0, a.x); }
    public static Vector4 Swizzle_xy0y(this Vector2 a) { return new Vector4(a.x, a.y, 0, a.y); }
    public static Vector4 Swizzle_xy00(this Vector2 a) { return new Vector4(a.x, a.y, 0, 0); }
    public static Vector4 Swizzle_xy01(this Vector2 a) { return new Vector4(a.x, a.y, 0, 1); }
    public static Vector4 Swizzle_xy1x(this Vector2 a) { return new Vector4(a.x, a.y, 1, a.x); }
    public static Vector4 Swizzle_xy1y(this Vector2 a) { return new Vector4(a.x, a.y, 1, a.y); }
    public static Vector4 Swizzle_xy10(this Vector2 a) { return new Vector4(a.x, a.y, 1, 0); }
    public static Vector4 Swizzle_xy11(this Vector2 a) { return new Vector4(a.x, a.y, 1, 1); }
    public static Vector4 Swizzle_x0xx(this Vector2 a) { return new Vector4(a.x, 0, a.x, a.x); }
    public static Vector4 Swizzle_x0xy(this Vector2 a) { return new Vector4(a.x, 0, a.x, a.y); }
    public static Vector4 Swizzle_x0x0(this Vector2 a) { return new Vector4(a.x, 0, a.x, 0); }
    public static Vector4 Swizzle_x0x1(this Vector2 a) { return new Vector4(a.x, 0, a.x, 1); }
    public static Vector4 Swizzle_x0yx(this Vector2 a) { return new Vector4(a.x, 0, a.y, a.x); }
    public static Vector4 Swizzle_x0yy(this Vector2 a) { return new Vector4(a.x, 0, a.y, a.y); }
    public static Vector4 Swizzle_x0y0(this Vector2 a) { return new Vector4(a.x, 0, a.y, 0); }
    public static Vector4 Swizzle_x0y1(this Vector2 a) { return new Vector4(a.x, 0, a.y, 1); }
    public static Vector4 Swizzle_x00x(this Vector2 a) { return new Vector4(a.x, 0, 0, a.x); }
    public static Vector4 Swizzle_x00y(this Vector2 a) { return new Vector4(a.x, 0, 0, a.y); }
    public static Vector4 Swizzle_x000(this Vector2 a) { return new Vector4(a.x, 0, 0, 0); }
    public static Vector4 Swizzle_x001(this Vector2 a) { return new Vector4(a.x, 0, 0, 1); }
    public static Vector4 Swizzle_x01x(this Vector2 a) { return new Vector4(a.x, 0, 1, a.x); }
    public static Vector4 Swizzle_x01y(this Vector2 a) { return new Vector4(a.x, 0, 1, a.y); }
    public static Vector4 Swizzle_x010(this Vector2 a) { return new Vector4(a.x, 0, 1, 0); }
    public static Vector4 Swizzle_x011(this Vector2 a) { return new Vector4(a.x, 0, 1, 1); }
    public static Vector4 Swizzle_x1xx(this Vector2 a) { return new Vector4(a.x, 1, a.x, a.x); }
    public static Vector4 Swizzle_x1xy(this Vector2 a) { return new Vector4(a.x, 1, a.x, a.y); }
    public static Vector4 Swizzle_x1x0(this Vector2 a) { return new Vector4(a.x, 1, a.x, 0); }
    public static Vector4 Swizzle_x1x1(this Vector2 a) { return new Vector4(a.x, 1, a.x, 1); }
    public static Vector4 Swizzle_x1yx(this Vector2 a) { return new Vector4(a.x, 1, a.y, a.x); }
    public static Vector4 Swizzle_x1yy(this Vector2 a) { return new Vector4(a.x, 1, a.y, a.y); }
    public static Vector4 Swizzle_x1y0(this Vector2 a) { return new Vector4(a.x, 1, a.y, 0); }
    public static Vector4 Swizzle_x1y1(this Vector2 a) { return new Vector4(a.x, 1, a.y, 1); }
    public static Vector4 Swizzle_x10x(this Vector2 a) { return new Vector4(a.x, 1, 0, a.x); }
    public static Vector4 Swizzle_x10y(this Vector2 a) { return new Vector4(a.x, 1, 0, a.y); }
    public static Vector4 Swizzle_x100(this Vector2 a) { return new Vector4(a.x, 1, 0, 0); }
    public static Vector4 Swizzle_x101(this Vector2 a) { return new Vector4(a.x, 1, 0, 1); }
    public static Vector4 Swizzle_x11x(this Vector2 a) { return new Vector4(a.x, 1, 1, a.x); }
    public static Vector4 Swizzle_x11y(this Vector2 a) { return new Vector4(a.x, 1, 1, a.y); }
    public static Vector4 Swizzle_x110(this Vector2 a) { return new Vector4(a.x, 1, 1, 0); }
    public static Vector4 Swizzle_x111(this Vector2 a) { return new Vector4(a.x, 1, 1, 1); }
    public static Vector4 Swizzle_yxxx(this Vector2 a) { return new Vector4(a.y, a.x, a.x, a.x); }
    public static Vector4 Swizzle_yxxy(this Vector2 a) { return new Vector4(a.y, a.x, a.x, a.y); }
    public static Vector4 Swizzle_yxx0(this Vector2 a) { return new Vector4(a.y, a.x, a.x, 0); }
    public static Vector4 Swizzle_yxx1(this Vector2 a) { return new Vector4(a.y, a.x, a.x, 1); }
    public static Vector4 Swizzle_yxyx(this Vector2 a) { return new Vector4(a.y, a.x, a.y, a.x); }
    public static Vector4 Swizzle_yxyy(this Vector2 a) { return new Vector4(a.y, a.x, a.y, a.y); }
    public static Vector4 Swizzle_yxy0(this Vector2 a) { return new Vector4(a.y, a.x, a.y, 0); }
    public static Vector4 Swizzle_yxy1(this Vector2 a) { return new Vector4(a.y, a.x, a.y, 1); }
    public static Vector4 Swizzle_yx0x(this Vector2 a) { return new Vector4(a.y, a.x, 0, a.x); }
    public static Vector4 Swizzle_yx0y(this Vector2 a) { return new Vector4(a.y, a.x, 0, a.y); }
    public static Vector4 Swizzle_yx00(this Vector2 a) { return new Vector4(a.y, a.x, 0, 0); }
    public static Vector4 Swizzle_yx01(this Vector2 a) { return new Vector4(a.y, a.x, 0, 1); }
    public static Vector4 Swizzle_yx1x(this Vector2 a) { return new Vector4(a.y, a.x, 1, a.x); }
    public static Vector4 Swizzle_yx1y(this Vector2 a) { return new Vector4(a.y, a.x, 1, a.y); }
    public static Vector4 Swizzle_yx10(this Vector2 a) { return new Vector4(a.y, a.x, 1, 0); }
    public static Vector4 Swizzle_yx11(this Vector2 a) { return new Vector4(a.y, a.x, 1, 1); }
    public static Vector4 Swizzle_yyxx(this Vector2 a) { return new Vector4(a.y, a.y, a.x, a.x); }
    public static Vector4 Swizzle_yyxy(this Vector2 a) { return new Vector4(a.y, a.y, a.x, a.y); }
    public static Vector4 Swizzle_yyx0(this Vector2 a) { return new Vector4(a.y, a.y, a.x, 0); }
    public static Vector4 Swizzle_yyx1(this Vector2 a) { return new Vector4(a.y, a.y, a.x, 1); }
    public static Vector4 Swizzle_yyyx(this Vector2 a) { return new Vector4(a.y, a.y, a.y, a.x); }
    public static Vector4 Swizzle_yyyy(this Vector2 a) { return new Vector4(a.y, a.y, a.y, a.y); }
    public static Vector4 Swizzle_yyy0(this Vector2 a) { return new Vector4(a.y, a.y, a.y, 0); }
    public static Vector4 Swizzle_yyy1(this Vector2 a) { return new Vector4(a.y, a.y, a.y, 1); }
    public static Vector4 Swizzle_yy0x(this Vector2 a) { return new Vector4(a.y, a.y, 0, a.x); }
    public static Vector4 Swizzle_yy0y(this Vector2 a) { return new Vector4(a.y, a.y, 0, a.y); }
    public static Vector4 Swizzle_yy00(this Vector2 a) { return new Vector4(a.y, a.y, 0, 0); }
    public static Vector4 Swizzle_yy01(this Vector2 a) { return new Vector4(a.y, a.y, 0, 1); }
    public static Vector4 Swizzle_yy1x(this Vector2 a) { return new Vector4(a.y, a.y, 1, a.x); }
    public static Vector4 Swizzle_yy1y(this Vector2 a) { return new Vector4(a.y, a.y, 1, a.y); }
    public static Vector4 Swizzle_yy10(this Vector2 a) { return new Vector4(a.y, a.y, 1, 0); }
    public static Vector4 Swizzle_yy11(this Vector2 a) { return new Vector4(a.y, a.y, 1, 1); }
    public static Vector4 Swizzle_y0xx(this Vector2 a) { return new Vector4(a.y, 0, a.x, a.x); }
    public static Vector4 Swizzle_y0xy(this Vector2 a) { return new Vector4(a.y, 0, a.x, a.y); }
    public static Vector4 Swizzle_y0x0(this Vector2 a) { return new Vector4(a.y, 0, a.x, 0); }
    public static Vector4 Swizzle_y0x1(this Vector2 a) { return new Vector4(a.y, 0, a.x, 1); }
    public static Vector4 Swizzle_y0yx(this Vector2 a) { return new Vector4(a.y, 0, a.y, a.x); }
    public static Vector4 Swizzle_y0yy(this Vector2 a) { return new Vector4(a.y, 0, a.y, a.y); }
    public static Vector4 Swizzle_y0y0(this Vector2 a) { return new Vector4(a.y, 0, a.y, 0); }
    public static Vector4 Swizzle_y0y1(this Vector2 a) { return new Vector4(a.y, 0, a.y, 1); }
    public static Vector4 Swizzle_y00x(this Vector2 a) { return new Vector4(a.y, 0, 0, a.x); }
    public static Vector4 Swizzle_y00y(this Vector2 a) { return new Vector4(a.y, 0, 0, a.y); }
    public static Vector4 Swizzle_y000(this Vector2 a) { return new Vector4(a.y, 0, 0, 0); }
    public static Vector4 Swizzle_y001(this Vector2 a) { return new Vector4(a.y, 0, 0, 1); }
    public static Vector4 Swizzle_y01x(this Vector2 a) { return new Vector4(a.y, 0, 1, a.x); }
    public static Vector4 Swizzle_y01y(this Vector2 a) { return new Vector4(a.y, 0, 1, a.y); }
    public static Vector4 Swizzle_y010(this Vector2 a) { return new Vector4(a.y, 0, 1, 0); }
    public static Vector4 Swizzle_y011(this Vector2 a) { return new Vector4(a.y, 0, 1, 1); }
    public static Vector4 Swizzle_y1xx(this Vector2 a) { return new Vector4(a.y, 1, a.x, a.x); }
    public static Vector4 Swizzle_y1xy(this Vector2 a) { return new Vector4(a.y, 1, a.x, a.y); }
    public static Vector4 Swizzle_y1x0(this Vector2 a) { return new Vector4(a.y, 1, a.x, 0); }
    public static Vector4 Swizzle_y1x1(this Vector2 a) { return new Vector4(a.y, 1, a.x, 1); }
    public static Vector4 Swizzle_y1yx(this Vector2 a) { return new Vector4(a.y, 1, a.y, a.x); }
    public static Vector4 Swizzle_y1yy(this Vector2 a) { return new Vector4(a.y, 1, a.y, a.y); }
    public static Vector4 Swizzle_y1y0(this Vector2 a) { return new Vector4(a.y, 1, a.y, 0); }
    public static Vector4 Swizzle_y1y1(this Vector2 a) { return new Vector4(a.y, 1, a.y, 1); }
    public static Vector4 Swizzle_y10x(this Vector2 a) { return new Vector4(a.y, 1, 0, a.x); }
    public static Vector4 Swizzle_y10y(this Vector2 a) { return new Vector4(a.y, 1, 0, a.y); }
    public static Vector4 Swizzle_y100(this Vector2 a) { return new Vector4(a.y, 1, 0, 0); }
    public static Vector4 Swizzle_y101(this Vector2 a) { return new Vector4(a.y, 1, 0, 1); }
    public static Vector4 Swizzle_y11x(this Vector2 a) { return new Vector4(a.y, 1, 1, a.x); }
    public static Vector4 Swizzle_y11y(this Vector2 a) { return new Vector4(a.y, 1, 1, a.y); }
    public static Vector4 Swizzle_y110(this Vector2 a) { return new Vector4(a.y, 1, 1, 0); }
    public static Vector4 Swizzle_y111(this Vector2 a) { return new Vector4(a.y, 1, 1, 1); }
    public static Vector4 Swizzle_0xxx(this Vector2 a) { return new Vector4(0, a.x, a.x, a.x); }
    public static Vector4 Swizzle_0xxy(this Vector2 a) { return new Vector4(0, a.x, a.x, a.y); }
    public static Vector4 Swizzle_0xx0(this Vector2 a) { return new Vector4(0, a.x, a.x, 0); }
    public static Vector4 Swizzle_0xx1(this Vector2 a) { return new Vector4(0, a.x, a.x, 1); }
    public static Vector4 Swizzle_0xyx(this Vector2 a) { return new Vector4(0, a.x, a.y, a.x); }
    public static Vector4 Swizzle_0xyy(this Vector2 a) { return new Vector4(0, a.x, a.y, a.y); }
    public static Vector4 Swizzle_0xy0(this Vector2 a) { return new Vector4(0, a.x, a.y, 0); }
    public static Vector4 Swizzle_0xy1(this Vector2 a) { return new Vector4(0, a.x, a.y, 1); }
    public static Vector4 Swizzle_0x0x(this Vector2 a) { return new Vector4(0, a.x, 0, a.x); }
    public static Vector4 Swizzle_0x0y(this Vector2 a) { return new Vector4(0, a.x, 0, a.y); }
    public static Vector4 Swizzle_0x00(this Vector2 a) { return new Vector4(0, a.x, 0, 0); }
    public static Vector4 Swizzle_0x01(this Vector2 a) { return new Vector4(0, a.x, 0, 1); }
    public static Vector4 Swizzle_0x1x(this Vector2 a) { return new Vector4(0, a.x, 1, a.x); }
    public static Vector4 Swizzle_0x1y(this Vector2 a) { return new Vector4(0, a.x, 1, a.y); }
    public static Vector4 Swizzle_0x10(this Vector2 a) { return new Vector4(0, a.x, 1, 0); }
    public static Vector4 Swizzle_0x11(this Vector2 a) { return new Vector4(0, a.x, 1, 1); }
    public static Vector4 Swizzle_0yxx(this Vector2 a) { return new Vector4(0, a.y, a.x, a.x); }
    public static Vector4 Swizzle_0yxy(this Vector2 a) { return new Vector4(0, a.y, a.x, a.y); }
    public static Vector4 Swizzle_0yx0(this Vector2 a) { return new Vector4(0, a.y, a.x, 0); }
    public static Vector4 Swizzle_0yx1(this Vector2 a) { return new Vector4(0, a.y, a.x, 1); }
    public static Vector4 Swizzle_0yyx(this Vector2 a) { return new Vector4(0, a.y, a.y, a.x); }
    public static Vector4 Swizzle_0yyy(this Vector2 a) { return new Vector4(0, a.y, a.y, a.y); }
    public static Vector4 Swizzle_0yy0(this Vector2 a) { return new Vector4(0, a.y, a.y, 0); }
    public static Vector4 Swizzle_0yy1(this Vector2 a) { return new Vector4(0, a.y, a.y, 1); }
    public static Vector4 Swizzle_0y0x(this Vector2 a) { return new Vector4(0, a.y, 0, a.x); }
    public static Vector4 Swizzle_0y0y(this Vector2 a) { return new Vector4(0, a.y, 0, a.y); }
    public static Vector4 Swizzle_0y00(this Vector2 a) { return new Vector4(0, a.y, 0, 0); }
    public static Vector4 Swizzle_0y01(this Vector2 a) { return new Vector4(0, a.y, 0, 1); }
    public static Vector4 Swizzle_0y1x(this Vector2 a) { return new Vector4(0, a.y, 1, a.x); }
    public static Vector4 Swizzle_0y1y(this Vector2 a) { return new Vector4(0, a.y, 1, a.y); }
    public static Vector4 Swizzle_0y10(this Vector2 a) { return new Vector4(0, a.y, 1, 0); }
    public static Vector4 Swizzle_0y11(this Vector2 a) { return new Vector4(0, a.y, 1, 1); }
    public static Vector4 Swizzle_00xx(this Vector2 a) { return new Vector4(0, 0, a.x, a.x); }
    public static Vector4 Swizzle_00xy(this Vector2 a) { return new Vector4(0, 0, a.x, a.y); }
    public static Vector4 Swizzle_00x0(this Vector2 a) { return new Vector4(0, 0, a.x, 0); }
    public static Vector4 Swizzle_00x1(this Vector2 a) { return new Vector4(0, 0, a.x, 1); }
    public static Vector4 Swizzle_00yx(this Vector2 a) { return new Vector4(0, 0, a.y, a.x); }
    public static Vector4 Swizzle_00yy(this Vector2 a) { return new Vector4(0, 0, a.y, a.y); }
    public static Vector4 Swizzle_00y0(this Vector2 a) { return new Vector4(0, 0, a.y, 0); }
    public static Vector4 Swizzle_00y1(this Vector2 a) { return new Vector4(0, 0, a.y, 1); }
    public static Vector4 Swizzle_000x(this Vector2 a) { return new Vector4(0, 0, 0, a.x); }
    public static Vector4 Swizzle_000y(this Vector2 a) { return new Vector4(0, 0, 0, a.y); }
    public static Vector4 Swizzle_0000(this Vector2 a) { return new Vector4(0, 0, 0, 0); }
    public static Vector4 Swizzle_0001(this Vector2 a) { return new Vector4(0, 0, 0, 1); }
    public static Vector4 Swizzle_001x(this Vector2 a) { return new Vector4(0, 0, 1, a.x); }
    public static Vector4 Swizzle_001y(this Vector2 a) { return new Vector4(0, 0, 1, a.y); }
    public static Vector4 Swizzle_0010(this Vector2 a) { return new Vector4(0, 0, 1, 0); }
    public static Vector4 Swizzle_0011(this Vector2 a) { return new Vector4(0, 0, 1, 1); }
    public static Vector4 Swizzle_01xx(this Vector2 a) { return new Vector4(0, 1, a.x, a.x); }
    public static Vector4 Swizzle_01xy(this Vector2 a) { return new Vector4(0, 1, a.x, a.y); }
    public static Vector4 Swizzle_01x0(this Vector2 a) { return new Vector4(0, 1, a.x, 0); }
    public static Vector4 Swizzle_01x1(this Vector2 a) { return new Vector4(0, 1, a.x, 1); }
    public static Vector4 Swizzle_01yx(this Vector2 a) { return new Vector4(0, 1, a.y, a.x); }
    public static Vector4 Swizzle_01yy(this Vector2 a) { return new Vector4(0, 1, a.y, a.y); }
    public static Vector4 Swizzle_01y0(this Vector2 a) { return new Vector4(0, 1, a.y, 0); }
    public static Vector4 Swizzle_01y1(this Vector2 a) { return new Vector4(0, 1, a.y, 1); }
    public static Vector4 Swizzle_010x(this Vector2 a) { return new Vector4(0, 1, 0, a.x); }
    public static Vector4 Swizzle_010y(this Vector2 a) { return new Vector4(0, 1, 0, a.y); }
    public static Vector4 Swizzle_0100(this Vector2 a) { return new Vector4(0, 1, 0, 0); }
    public static Vector4 Swizzle_0101(this Vector2 a) { return new Vector4(0, 1, 0, 1); }
    public static Vector4 Swizzle_011x(this Vector2 a) { return new Vector4(0, 1, 1, a.x); }
    public static Vector4 Swizzle_011y(this Vector2 a) { return new Vector4(0, 1, 1, a.y); }
    public static Vector4 Swizzle_0110(this Vector2 a) { return new Vector4(0, 1, 1, 0); }
    public static Vector4 Swizzle_0111(this Vector2 a) { return new Vector4(0, 1, 1, 1); }
    public static Vector4 Swizzle_1xxx(this Vector2 a) { return new Vector4(1, a.x, a.x, a.x); }
    public static Vector4 Swizzle_1xxy(this Vector2 a) { return new Vector4(1, a.x, a.x, a.y); }
    public static Vector4 Swizzle_1xx0(this Vector2 a) { return new Vector4(1, a.x, a.x, 0); }
    public static Vector4 Swizzle_1xx1(this Vector2 a) { return new Vector4(1, a.x, a.x, 1); }
    public static Vector4 Swizzle_1xyx(this Vector2 a) { return new Vector4(1, a.x, a.y, a.x); }
    public static Vector4 Swizzle_1xyy(this Vector2 a) { return new Vector4(1, a.x, a.y, a.y); }
    public static Vector4 Swizzle_1xy0(this Vector2 a) { return new Vector4(1, a.x, a.y, 0); }
    public static Vector4 Swizzle_1xy1(this Vector2 a) { return new Vector4(1, a.x, a.y, 1); }
    public static Vector4 Swizzle_1x0x(this Vector2 a) { return new Vector4(1, a.x, 0, a.x); }
    public static Vector4 Swizzle_1x0y(this Vector2 a) { return new Vector4(1, a.x, 0, a.y); }
    public static Vector4 Swizzle_1x00(this Vector2 a) { return new Vector4(1, a.x, 0, 0); }
    public static Vector4 Swizzle_1x01(this Vector2 a) { return new Vector4(1, a.x, 0, 1); }
    public static Vector4 Swizzle_1x1x(this Vector2 a) { return new Vector4(1, a.x, 1, a.x); }
    public static Vector4 Swizzle_1x1y(this Vector2 a) { return new Vector4(1, a.x, 1, a.y); }
    public static Vector4 Swizzle_1x10(this Vector2 a) { return new Vector4(1, a.x, 1, 0); }
    public static Vector4 Swizzle_1x11(this Vector2 a) { return new Vector4(1, a.x, 1, 1); }
    public static Vector4 Swizzle_1yxx(this Vector2 a) { return new Vector4(1, a.y, a.x, a.x); }
    public static Vector4 Swizzle_1yxy(this Vector2 a) { return new Vector4(1, a.y, a.x, a.y); }
    public static Vector4 Swizzle_1yx0(this Vector2 a) { return new Vector4(1, a.y, a.x, 0); }
    public static Vector4 Swizzle_1yx1(this Vector2 a) { return new Vector4(1, a.y, a.x, 1); }
    public static Vector4 Swizzle_1yyx(this Vector2 a) { return new Vector4(1, a.y, a.y, a.x); }
    public static Vector4 Swizzle_1yyy(this Vector2 a) { return new Vector4(1, a.y, a.y, a.y); }
    public static Vector4 Swizzle_1yy0(this Vector2 a) { return new Vector4(1, a.y, a.y, 0); }
    public static Vector4 Swizzle_1yy1(this Vector2 a) { return new Vector4(1, a.y, a.y, 1); }
    public static Vector4 Swizzle_1y0x(this Vector2 a) { return new Vector4(1, a.y, 0, a.x); }
    public static Vector4 Swizzle_1y0y(this Vector2 a) { return new Vector4(1, a.y, 0, a.y); }
    public static Vector4 Swizzle_1y00(this Vector2 a) { return new Vector4(1, a.y, 0, 0); }
    public static Vector4 Swizzle_1y01(this Vector2 a) { return new Vector4(1, a.y, 0, 1); }
    public static Vector4 Swizzle_1y1x(this Vector2 a) { return new Vector4(1, a.y, 1, a.x); }
    public static Vector4 Swizzle_1y1y(this Vector2 a) { return new Vector4(1, a.y, 1, a.y); }
    public static Vector4 Swizzle_1y10(this Vector2 a) { return new Vector4(1, a.y, 1, 0); }
    public static Vector4 Swizzle_1y11(this Vector2 a) { return new Vector4(1, a.y, 1, 1); }
    public static Vector4 Swizzle_10xx(this Vector2 a) { return new Vector4(1, 0, a.x, a.x); }
    public static Vector4 Swizzle_10xy(this Vector2 a) { return new Vector4(1, 0, a.x, a.y); }
    public static Vector4 Swizzle_10x0(this Vector2 a) { return new Vector4(1, 0, a.x, 0); }
    public static Vector4 Swizzle_10x1(this Vector2 a) { return new Vector4(1, 0, a.x, 1); }
    public static Vector4 Swizzle_10yx(this Vector2 a) { return new Vector4(1, 0, a.y, a.x); }
    public static Vector4 Swizzle_10yy(this Vector2 a) { return new Vector4(1, 0, a.y, a.y); }
    public static Vector4 Swizzle_10y0(this Vector2 a) { return new Vector4(1, 0, a.y, 0); }
    public static Vector4 Swizzle_10y1(this Vector2 a) { return new Vector4(1, 0, a.y, 1); }
    public static Vector4 Swizzle_100x(this Vector2 a) { return new Vector4(1, 0, 0, a.x); }
    public static Vector4 Swizzle_100y(this Vector2 a) { return new Vector4(1, 0, 0, a.y); }
    public static Vector4 Swizzle_1000(this Vector2 a) { return new Vector4(1, 0, 0, 0); }
    public static Vector4 Swizzle_1001(this Vector2 a) { return new Vector4(1, 0, 0, 1); }
    public static Vector4 Swizzle_101x(this Vector2 a) { return new Vector4(1, 0, 1, a.x); }
    public static Vector4 Swizzle_101y(this Vector2 a) { return new Vector4(1, 0, 1, a.y); }
    public static Vector4 Swizzle_1010(this Vector2 a) { return new Vector4(1, 0, 1, 0); }
    public static Vector4 Swizzle_1011(this Vector2 a) { return new Vector4(1, 0, 1, 1); }
    public static Vector4 Swizzle_11xx(this Vector2 a) { return new Vector4(1, 1, a.x, a.x); }
    public static Vector4 Swizzle_11xy(this Vector2 a) { return new Vector4(1, 1, a.x, a.y); }
    public static Vector4 Swizzle_11x0(this Vector2 a) { return new Vector4(1, 1, a.x, 0); }
    public static Vector4 Swizzle_11x1(this Vector2 a) { return new Vector4(1, 1, a.x, 1); }
    public static Vector4 Swizzle_11yx(this Vector2 a) { return new Vector4(1, 1, a.y, a.x); }
    public static Vector4 Swizzle_11yy(this Vector2 a) { return new Vector4(1, 1, a.y, a.y); }
    public static Vector4 Swizzle_11y0(this Vector2 a) { return new Vector4(1, 1, a.y, 0); }
    public static Vector4 Swizzle_11y1(this Vector2 a) { return new Vector4(1, 1, a.y, 1); }
    public static Vector4 Swizzle_110x(this Vector2 a) { return new Vector4(1, 1, 0, a.x); }
    public static Vector4 Swizzle_110y(this Vector2 a) { return new Vector4(1, 1, 0, a.y); }
    public static Vector4 Swizzle_1100(this Vector2 a) { return new Vector4(1, 1, 0, 0); }
    public static Vector4 Swizzle_1101(this Vector2 a) { return new Vector4(1, 1, 0, 1); }
    public static Vector4 Swizzle_111x(this Vector2 a) { return new Vector4(1, 1, 1, a.x); }
    public static Vector4 Swizzle_111y(this Vector2 a) { return new Vector4(1, 1, 1, a.y); }
    public static Vector4 Swizzle_1110(this Vector2 a) { return new Vector4(1, 1, 1, 0); }
    public static Vector4 Swizzle_1111(this Vector2 a) { return new Vector4(1, 1, 1, 1); }
    public static Vector2 Swizzle_xx(this Vector3 a) { return new Vector2(a.x, a.x); }
    public static Vector2 Swizzle_xy(this Vector3 a) { return new Vector2(a.x, a.y); }
    public static Vector2 Swizzle_xz(this Vector3 a) { return new Vector2(a.x, a.z); }
    public static Vector2 Swizzle_x0(this Vector3 a) { return new Vector2(a.x, 0); }
    public static Vector2 Swizzle_x1(this Vector3 a) { return new Vector2(a.x, 1); }
    public static Vector2 Swizzle_yx(this Vector3 a) { return new Vector2(a.y, a.x); }
    public static Vector2 Swizzle_yy(this Vector3 a) { return new Vector2(a.y, a.y); }
    public static Vector2 Swizzle_yz(this Vector3 a) { return new Vector2(a.y, a.z); }
    public static Vector2 Swizzle_y0(this Vector3 a) { return new Vector2(a.y, 0); }
    public static Vector2 Swizzle_y1(this Vector3 a) { return new Vector2(a.y, 1); }
    public static Vector2 Swizzle_zx(this Vector3 a) { return new Vector2(a.z, a.x); }
    public static Vector2 Swizzle_zy(this Vector3 a) { return new Vector2(a.z, a.y); }
    public static Vector2 Swizzle_zz(this Vector3 a) { return new Vector2(a.z, a.z); }
    public static Vector2 Swizzle_z0(this Vector3 a) { return new Vector2(a.z, 0); }
    public static Vector2 Swizzle_z1(this Vector3 a) { return new Vector2(a.z, 1); }
    public static Vector2 Swizzle_0x(this Vector3 a) { return new Vector2(0, a.x); }
    public static Vector2 Swizzle_0y(this Vector3 a) { return new Vector2(0, a.y); }
    public static Vector2 Swizzle_0z(this Vector3 a) { return new Vector2(0, a.z); }
    public static Vector2 Swizzle_00(this Vector3 a) { return new Vector2(0, 0); }
    public static Vector2 Swizzle_01(this Vector3 a) { return new Vector2(0, 1); }
    public static Vector2 Swizzle_1x(this Vector3 a) { return new Vector2(1, a.x); }
    public static Vector2 Swizzle_1y(this Vector3 a) { return new Vector2(1, a.y); }
    public static Vector2 Swizzle_1z(this Vector3 a) { return new Vector2(1, a.z); }
    public static Vector2 Swizzle_10(this Vector3 a) { return new Vector2(1, 0); }
    public static Vector2 Swizzle_11(this Vector3 a) { return new Vector2(1, 1); }
    public static Vector3 Swizzle_xxx(this Vector3 a) { return new Vector3(a.x, a.x, a.x); }
    public static Vector3 Swizzle_xxy(this Vector3 a) { return new Vector3(a.x, a.x, a.y); }
    public static Vector3 Swizzle_xxz(this Vector3 a) { return new Vector3(a.x, a.x, a.z); }
    public static Vector3 Swizzle_xx0(this Vector3 a) { return new Vector3(a.x, a.x, 0); }
    public static Vector3 Swizzle_xx1(this Vector3 a) { return new Vector3(a.x, a.x, 1); }
    public static Vector3 Swizzle_xyx(this Vector3 a) { return new Vector3(a.x, a.y, a.x); }
    public static Vector3 Swizzle_xyy(this Vector3 a) { return new Vector3(a.x, a.y, a.y); }
    public static Vector3 Swizzle_xyz(this Vector3 a) { return new Vector3(a.x, a.y, a.z); }
    public static Vector3 Swizzle_xy0(this Vector3 a) { return new Vector3(a.x, a.y, 0); }
    public static Vector3 Swizzle_xy1(this Vector3 a) { return new Vector3(a.x, a.y, 1); }
    public static Vector3 Swizzle_xzx(this Vector3 a) { return new Vector3(a.x, a.z, a.x); }
    public static Vector3 Swizzle_xzy(this Vector3 a) { return new Vector3(a.x, a.z, a.y); }
    public static Vector3 Swizzle_xzz(this Vector3 a) { return new Vector3(a.x, a.z, a.z); }
    public static Vector3 Swizzle_xz0(this Vector3 a) { return new Vector3(a.x, a.z, 0); }
    public static Vector3 Swizzle_xz1(this Vector3 a) { return new Vector3(a.x, a.z, 1); }
    public static Vector3 Swizzle_x0x(this Vector3 a) { return new Vector3(a.x, 0, a.x); }
    public static Vector3 Swizzle_x0y(this Vector3 a) { return new Vector3(a.x, 0, a.y); }
    public static Vector3 Swizzle_x0z(this Vector3 a) { return new Vector3(a.x, 0, a.z); }
    public static Vector3 Swizzle_x00(this Vector3 a) { return new Vector3(a.x, 0, 0); }
    public static Vector3 Swizzle_x01(this Vector3 a) { return new Vector3(a.x, 0, 1); }
    public static Vector3 Swizzle_x1x(this Vector3 a) { return new Vector3(a.x, 1, a.x); }
    public static Vector3 Swizzle_x1y(this Vector3 a) { return new Vector3(a.x, 1, a.y); }
    public static Vector3 Swizzle_x1z(this Vector3 a) { return new Vector3(a.x, 1, a.z); }
    public static Vector3 Swizzle_x10(this Vector3 a) { return new Vector3(a.x, 1, 0); }
    public static Vector3 Swizzle_x11(this Vector3 a) { return new Vector3(a.x, 1, 1); }
    public static Vector3 Swizzle_yxx(this Vector3 a) { return new Vector3(a.y, a.x, a.x); }
    public static Vector3 Swizzle_yxy(this Vector3 a) { return new Vector3(a.y, a.x, a.y); }
    public static Vector3 Swizzle_yxz(this Vector3 a) { return new Vector3(a.y, a.x, a.z); }
    public static Vector3 Swizzle_yx0(this Vector3 a) { return new Vector3(a.y, a.x, 0); }
    public static Vector3 Swizzle_yx1(this Vector3 a) { return new Vector3(a.y, a.x, 1); }
    public static Vector3 Swizzle_yyx(this Vector3 a) { return new Vector3(a.y, a.y, a.x); }
    public static Vector3 Swizzle_yyy(this Vector3 a) { return new Vector3(a.y, a.y, a.y); }
    public static Vector3 Swizzle_yyz(this Vector3 a) { return new Vector3(a.y, a.y, a.z); }
    public static Vector3 Swizzle_yy0(this Vector3 a) { return new Vector3(a.y, a.y, 0); }
    public static Vector3 Swizzle_yy1(this Vector3 a) { return new Vector3(a.y, a.y, 1); }
    public static Vector3 Swizzle_yzx(this Vector3 a) { return new Vector3(a.y, a.z, a.x); }
    public static Vector3 Swizzle_yzy(this Vector3 a) { return new Vector3(a.y, a.z, a.y); }
    public static Vector3 Swizzle_yzz(this Vector3 a) { return new Vector3(a.y, a.z, a.z); }
    public static Vector3 Swizzle_yz0(this Vector3 a) { return new Vector3(a.y, a.z, 0); }
    public static Vector3 Swizzle_yz1(this Vector3 a) { return new Vector3(a.y, a.z, 1); }
    public static Vector3 Swizzle_y0x(this Vector3 a) { return new Vector3(a.y, 0, a.x); }
    public static Vector3 Swizzle_y0y(this Vector3 a) { return new Vector3(a.y, 0, a.y); }
    public static Vector3 Swizzle_y0z(this Vector3 a) { return new Vector3(a.y, 0, a.z); }
    public static Vector3 Swizzle_y00(this Vector3 a) { return new Vector3(a.y, 0, 0); }
    public static Vector3 Swizzle_y01(this Vector3 a) { return new Vector3(a.y, 0, 1); }
    public static Vector3 Swizzle_y1x(this Vector3 a) { return new Vector3(a.y, 1, a.x); }
    public static Vector3 Swizzle_y1y(this Vector3 a) { return new Vector3(a.y, 1, a.y); }
    public static Vector3 Swizzle_y1z(this Vector3 a) { return new Vector3(a.y, 1, a.z); }
    public static Vector3 Swizzle_y10(this Vector3 a) { return new Vector3(a.y, 1, 0); }
    public static Vector3 Swizzle_y11(this Vector3 a) { return new Vector3(a.y, 1, 1); }
    public static Vector3 Swizzle_zxx(this Vector3 a) { return new Vector3(a.z, a.x, a.x); }
    public static Vector3 Swizzle_zxy(this Vector3 a) { return new Vector3(a.z, a.x, a.y); }
    public static Vector3 Swizzle_zxz(this Vector3 a) { return new Vector3(a.z, a.x, a.z); }
    public static Vector3 Swizzle_zx0(this Vector3 a) { return new Vector3(a.z, a.x, 0); }
    public static Vector3 Swizzle_zx1(this Vector3 a) { return new Vector3(a.z, a.x, 1); }
    public static Vector3 Swizzle_zyx(this Vector3 a) { return new Vector3(a.z, a.y, a.x); }
    public static Vector3 Swizzle_zyy(this Vector3 a) { return new Vector3(a.z, a.y, a.y); }
    public static Vector3 Swizzle_zyz(this Vector3 a) { return new Vector3(a.z, a.y, a.z); }
    public static Vector3 Swizzle_zy0(this Vector3 a) { return new Vector3(a.z, a.y, 0); }
    public static Vector3 Swizzle_zy1(this Vector3 a) { return new Vector3(a.z, a.y, 1); }
    public static Vector3 Swizzle_zzx(this Vector3 a) { return new Vector3(a.z, a.z, a.x); }
    public static Vector3 Swizzle_zzy(this Vector3 a) { return new Vector3(a.z, a.z, a.y); }
    public static Vector3 Swizzle_zzz(this Vector3 a) { return new Vector3(a.z, a.z, a.z); }
    public static Vector3 Swizzle_zz0(this Vector3 a) { return new Vector3(a.z, a.z, 0); }
    public static Vector3 Swizzle_zz1(this Vector3 a) { return new Vector3(a.z, a.z, 1); }
    public static Vector3 Swizzle_z0x(this Vector3 a) { return new Vector3(a.z, 0, a.x); }
    public static Vector3 Swizzle_z0y(this Vector3 a) { return new Vector3(a.z, 0, a.y); }
    public static Vector3 Swizzle_z0z(this Vector3 a) { return new Vector3(a.z, 0, a.z); }
    public static Vector3 Swizzle_z00(this Vector3 a) { return new Vector3(a.z, 0, 0); }
    public static Vector3 Swizzle_z01(this Vector3 a) { return new Vector3(a.z, 0, 1); }
    public static Vector3 Swizzle_z1x(this Vector3 a) { return new Vector3(a.z, 1, a.x); }
    public static Vector3 Swizzle_z1y(this Vector3 a) { return new Vector3(a.z, 1, a.y); }
    public static Vector3 Swizzle_z1z(this Vector3 a) { return new Vector3(a.z, 1, a.z); }
    public static Vector3 Swizzle_z10(this Vector3 a) { return new Vector3(a.z, 1, 0); }
    public static Vector3 Swizzle_z11(this Vector3 a) { return new Vector3(a.z, 1, 1); }
    public static Vector3 Swizzle_0xx(this Vector3 a) { return new Vector3(0, a.x, a.x); }
    public static Vector3 Swizzle_0xy(this Vector3 a) { return new Vector3(0, a.x, a.y); }
    public static Vector3 Swizzle_0xz(this Vector3 a) { return new Vector3(0, a.x, a.z); }
    public static Vector3 Swizzle_0x0(this Vector3 a) { return new Vector3(0, a.x, 0); }
    public static Vector3 Swizzle_0x1(this Vector3 a) { return new Vector3(0, a.x, 1); }
    public static Vector3 Swizzle_0yx(this Vector3 a) { return new Vector3(0, a.y, a.x); }
    public static Vector3 Swizzle_0yy(this Vector3 a) { return new Vector3(0, a.y, a.y); }
    public static Vector3 Swizzle_0yz(this Vector3 a) { return new Vector3(0, a.y, a.z); }
    public static Vector3 Swizzle_0y0(this Vector3 a) { return new Vector3(0, a.y, 0); }
    public static Vector3 Swizzle_0y1(this Vector3 a) { return new Vector3(0, a.y, 1); }
    public static Vector3 Swizzle_0zx(this Vector3 a) { return new Vector3(0, a.z, a.x); }
    public static Vector3 Swizzle_0zy(this Vector3 a) { return new Vector3(0, a.z, a.y); }
    public static Vector3 Swizzle_0zz(this Vector3 a) { return new Vector3(0, a.z, a.z); }
    public static Vector3 Swizzle_0z0(this Vector3 a) { return new Vector3(0, a.z, 0); }
    public static Vector3 Swizzle_0z1(this Vector3 a) { return new Vector3(0, a.z, 1); }
    public static Vector3 Swizzle_00x(this Vector3 a) { return new Vector3(0, 0, a.x); }
    public static Vector3 Swizzle_00y(this Vector3 a) { return new Vector3(0, 0, a.y); }
    public static Vector3 Swizzle_00z(this Vector3 a) { return new Vector3(0, 0, a.z); }
    public static Vector3 Swizzle_000(this Vector3 a) { return new Vector3(0, 0, 0); }
    public static Vector3 Swizzle_001(this Vector3 a) { return new Vector3(0, 0, 1); }
    public static Vector3 Swizzle_01x(this Vector3 a) { return new Vector3(0, 1, a.x); }
    public static Vector3 Swizzle_01y(this Vector3 a) { return new Vector3(0, 1, a.y); }
    public static Vector3 Swizzle_01z(this Vector3 a) { return new Vector3(0, 1, a.z); }
    public static Vector3 Swizzle_010(this Vector3 a) { return new Vector3(0, 1, 0); }
    public static Vector3 Swizzle_011(this Vector3 a) { return new Vector3(0, 1, 1); }
    public static Vector3 Swizzle_1xx(this Vector3 a) { return new Vector3(1, a.x, a.x); }
    public static Vector3 Swizzle_1xy(this Vector3 a) { return new Vector3(1, a.x, a.y); }
    public static Vector3 Swizzle_1xz(this Vector3 a) { return new Vector3(1, a.x, a.z); }
    public static Vector3 Swizzle_1x0(this Vector3 a) { return new Vector3(1, a.x, 0); }
    public static Vector3 Swizzle_1x1(this Vector3 a) { return new Vector3(1, a.x, 1); }
    public static Vector3 Swizzle_1yx(this Vector3 a) { return new Vector3(1, a.y, a.x); }
    public static Vector3 Swizzle_1yy(this Vector3 a) { return new Vector3(1, a.y, a.y); }
    public static Vector3 Swizzle_1yz(this Vector3 a) { return new Vector3(1, a.y, a.z); }
    public static Vector3 Swizzle_1y0(this Vector3 a) { return new Vector3(1, a.y, 0); }
    public static Vector3 Swizzle_1y1(this Vector3 a) { return new Vector3(1, a.y, 1); }
    public static Vector3 Swizzle_1zx(this Vector3 a) { return new Vector3(1, a.z, a.x); }
    public static Vector3 Swizzle_1zy(this Vector3 a) { return new Vector3(1, a.z, a.y); }
    public static Vector3 Swizzle_1zz(this Vector3 a) { return new Vector3(1, a.z, a.z); }
    public static Vector3 Swizzle_1z0(this Vector3 a) { return new Vector3(1, a.z, 0); }
    public static Vector3 Swizzle_1z1(this Vector3 a) { return new Vector3(1, a.z, 1); }
    public static Vector3 Swizzle_10x(this Vector3 a) { return new Vector3(1, 0, a.x); }
    public static Vector3 Swizzle_10y(this Vector3 a) { return new Vector3(1, 0, a.y); }
    public static Vector3 Swizzle_10z(this Vector3 a) { return new Vector3(1, 0, a.z); }
    public static Vector3 Swizzle_100(this Vector3 a) { return new Vector3(1, 0, 0); }
    public static Vector3 Swizzle_101(this Vector3 a) { return new Vector3(1, 0, 1); }
    public static Vector3 Swizzle_11x(this Vector3 a) { return new Vector3(1, 1, a.x); }
    public static Vector3 Swizzle_11y(this Vector3 a) { return new Vector3(1, 1, a.y); }
    public static Vector3 Swizzle_11z(this Vector3 a) { return new Vector3(1, 1, a.z); }
    public static Vector3 Swizzle_110(this Vector3 a) { return new Vector3(1, 1, 0); }
    public static Vector3 Swizzle_111(this Vector3 a) { return new Vector3(1, 1, 1); }
    public static Vector4 Swizzle_xxxx(this Vector3 a) { return new Vector4(a.x, a.x, a.x, a.x); }
    public static Vector4 Swizzle_xxxy(this Vector3 a) { return new Vector4(a.x, a.x, a.x, a.y); }
    public static Vector4 Swizzle_xxxz(this Vector3 a) { return new Vector4(a.x, a.x, a.x, a.z); }
    public static Vector4 Swizzle_xxx0(this Vector3 a) { return new Vector4(a.x, a.x, a.x, 0); }
    public static Vector4 Swizzle_xxx1(this Vector3 a) { return new Vector4(a.x, a.x, a.x, 1); }
    public static Vector4 Swizzle_xxyx(this Vector3 a) { return new Vector4(a.x, a.x, a.y, a.x); }
    public static Vector4 Swizzle_xxyy(this Vector3 a) { return new Vector4(a.x, a.x, a.y, a.y); }
    public static Vector4 Swizzle_xxyz(this Vector3 a) { return new Vector4(a.x, a.x, a.y, a.z); }
    public static Vector4 Swizzle_xxy0(this Vector3 a) { return new Vector4(a.x, a.x, a.y, 0); }
    public static Vector4 Swizzle_xxy1(this Vector3 a) { return new Vector4(a.x, a.x, a.y, 1); }
    public static Vector4 Swizzle_xxzx(this Vector3 a) { return new Vector4(a.x, a.x, a.z, a.x); }
    public static Vector4 Swizzle_xxzy(this Vector3 a) { return new Vector4(a.x, a.x, a.z, a.y); }
    public static Vector4 Swizzle_xxzz(this Vector3 a) { return new Vector4(a.x, a.x, a.z, a.z); }
    public static Vector4 Swizzle_xxz0(this Vector3 a) { return new Vector4(a.x, a.x, a.z, 0); }
    public static Vector4 Swizzle_xxz1(this Vector3 a) { return new Vector4(a.x, a.x, a.z, 1); }
    public static Vector4 Swizzle_xx0x(this Vector3 a) { return new Vector4(a.x, a.x, 0, a.x); }
    public static Vector4 Swizzle_xx0y(this Vector3 a) { return new Vector4(a.x, a.x, 0, a.y); }
    public static Vector4 Swizzle_xx0z(this Vector3 a) { return new Vector4(a.x, a.x, 0, a.z); }
    public static Vector4 Swizzle_xx00(this Vector3 a) { return new Vector4(a.x, a.x, 0, 0); }
    public static Vector4 Swizzle_xx01(this Vector3 a) { return new Vector4(a.x, a.x, 0, 1); }
    public static Vector4 Swizzle_xx1x(this Vector3 a) { return new Vector4(a.x, a.x, 1, a.x); }
    public static Vector4 Swizzle_xx1y(this Vector3 a) { return new Vector4(a.x, a.x, 1, a.y); }
    public static Vector4 Swizzle_xx1z(this Vector3 a) { return new Vector4(a.x, a.x, 1, a.z); }
    public static Vector4 Swizzle_xx10(this Vector3 a) { return new Vector4(a.x, a.x, 1, 0); }
    public static Vector4 Swizzle_xx11(this Vector3 a) { return new Vector4(a.x, a.x, 1, 1); }
    public static Vector4 Swizzle_xyxx(this Vector3 a) { return new Vector4(a.x, a.y, a.x, a.x); }
    public static Vector4 Swizzle_xyxy(this Vector3 a) { return new Vector4(a.x, a.y, a.x, a.y); }
    public static Vector4 Swizzle_xyxz(this Vector3 a) { return new Vector4(a.x, a.y, a.x, a.z); }
    public static Vector4 Swizzle_xyx0(this Vector3 a) { return new Vector4(a.x, a.y, a.x, 0); }
    public static Vector4 Swizzle_xyx1(this Vector3 a) { return new Vector4(a.x, a.y, a.x, 1); }
    public static Vector4 Swizzle_xyyx(this Vector3 a) { return new Vector4(a.x, a.y, a.y, a.x); }
    public static Vector4 Swizzle_xyyy(this Vector3 a) { return new Vector4(a.x, a.y, a.y, a.y); }
    public static Vector4 Swizzle_xyyz(this Vector3 a) { return new Vector4(a.x, a.y, a.y, a.z); }
    public static Vector4 Swizzle_xyy0(this Vector3 a) { return new Vector4(a.x, a.y, a.y, 0); }
    public static Vector4 Swizzle_xyy1(this Vector3 a) { return new Vector4(a.x, a.y, a.y, 1); }
    public static Vector4 Swizzle_xyzx(this Vector3 a) { return new Vector4(a.x, a.y, a.z, a.x); }
    public static Vector4 Swizzle_xyzy(this Vector3 a) { return new Vector4(a.x, a.y, a.z, a.y); }
    public static Vector4 Swizzle_xyzz(this Vector3 a) { return new Vector4(a.x, a.y, a.z, a.z); }
    public static Vector4 Swizzle_xyz0(this Vector3 a) { return new Vector4(a.x, a.y, a.z, 0); }
    public static Vector4 Swizzle_xyz1(this Vector3 a) { return new Vector4(a.x, a.y, a.z, 1); }
    public static Vector4 Swizzle_xy0x(this Vector3 a) { return new Vector4(a.x, a.y, 0, a.x); }
    public static Vector4 Swizzle_xy0y(this Vector3 a) { return new Vector4(a.x, a.y, 0, a.y); }
    public static Vector4 Swizzle_xy0z(this Vector3 a) { return new Vector4(a.x, a.y, 0, a.z); }
    public static Vector4 Swizzle_xy00(this Vector3 a) { return new Vector4(a.x, a.y, 0, 0); }
    public static Vector4 Swizzle_xy01(this Vector3 a) { return new Vector4(a.x, a.y, 0, 1); }
    public static Vector4 Swizzle_xy1x(this Vector3 a) { return new Vector4(a.x, a.y, 1, a.x); }
    public static Vector4 Swizzle_xy1y(this Vector3 a) { return new Vector4(a.x, a.y, 1, a.y); }
    public static Vector4 Swizzle_xy1z(this Vector3 a) { return new Vector4(a.x, a.y, 1, a.z); }
    public static Vector4 Swizzle_xy10(this Vector3 a) { return new Vector4(a.x, a.y, 1, 0); }
    public static Vector4 Swizzle_xy11(this Vector3 a) { return new Vector4(a.x, a.y, 1, 1); }
    public static Vector4 Swizzle_xzxx(this Vector3 a) { return new Vector4(a.x, a.z, a.x, a.x); }
    public static Vector4 Swizzle_xzxy(this Vector3 a) { return new Vector4(a.x, a.z, a.x, a.y); }
    public static Vector4 Swizzle_xzxz(this Vector3 a) { return new Vector4(a.x, a.z, a.x, a.z); }
    public static Vector4 Swizzle_xzx0(this Vector3 a) { return new Vector4(a.x, a.z, a.x, 0); }
    public static Vector4 Swizzle_xzx1(this Vector3 a) { return new Vector4(a.x, a.z, a.x, 1); }
    public static Vector4 Swizzle_xzyx(this Vector3 a) { return new Vector4(a.x, a.z, a.y, a.x); }
    public static Vector4 Swizzle_xzyy(this Vector3 a) { return new Vector4(a.x, a.z, a.y, a.y); }
    public static Vector4 Swizzle_xzyz(this Vector3 a) { return new Vector4(a.x, a.z, a.y, a.z); }
    public static Vector4 Swizzle_xzy0(this Vector3 a) { return new Vector4(a.x, a.z, a.y, 0); }
    public static Vector4 Swizzle_xzy1(this Vector3 a) { return new Vector4(a.x, a.z, a.y, 1); }
    public static Vector4 Swizzle_xzzx(this Vector3 a) { return new Vector4(a.x, a.z, a.z, a.x); }
    public static Vector4 Swizzle_xzzy(this Vector3 a) { return new Vector4(a.x, a.z, a.z, a.y); }
    public static Vector4 Swizzle_xzzz(this Vector3 a) { return new Vector4(a.x, a.z, a.z, a.z); }
    public static Vector4 Swizzle_xzz0(this Vector3 a) { return new Vector4(a.x, a.z, a.z, 0); }
    public static Vector4 Swizzle_xzz1(this Vector3 a) { return new Vector4(a.x, a.z, a.z, 1); }
    public static Vector4 Swizzle_xz0x(this Vector3 a) { return new Vector4(a.x, a.z, 0, a.x); }
    public static Vector4 Swizzle_xz0y(this Vector3 a) { return new Vector4(a.x, a.z, 0, a.y); }
    public static Vector4 Swizzle_xz0z(this Vector3 a) { return new Vector4(a.x, a.z, 0, a.z); }
    public static Vector4 Swizzle_xz00(this Vector3 a) { return new Vector4(a.x, a.z, 0, 0); }
    public static Vector4 Swizzle_xz01(this Vector3 a) { return new Vector4(a.x, a.z, 0, 1); }
    public static Vector4 Swizzle_xz1x(this Vector3 a) { return new Vector4(a.x, a.z, 1, a.x); }
    public static Vector4 Swizzle_xz1y(this Vector3 a) { return new Vector4(a.x, a.z, 1, a.y); }
    public static Vector4 Swizzle_xz1z(this Vector3 a) { return new Vector4(a.x, a.z, 1, a.z); }
    public static Vector4 Swizzle_xz10(this Vector3 a) { return new Vector4(a.x, a.z, 1, 0); }
    public static Vector4 Swizzle_xz11(this Vector3 a) { return new Vector4(a.x, a.z, 1, 1); }
    public static Vector4 Swizzle_x0xx(this Vector3 a) { return new Vector4(a.x, 0, a.x, a.x); }
    public static Vector4 Swizzle_x0xy(this Vector3 a) { return new Vector4(a.x, 0, a.x, a.y); }
    public static Vector4 Swizzle_x0xz(this Vector3 a) { return new Vector4(a.x, 0, a.x, a.z); }
    public static Vector4 Swizzle_x0x0(this Vector3 a) { return new Vector4(a.x, 0, a.x, 0); }
    public static Vector4 Swizzle_x0x1(this Vector3 a) { return new Vector4(a.x, 0, a.x, 1); }
    public static Vector4 Swizzle_x0yx(this Vector3 a) { return new Vector4(a.x, 0, a.y, a.x); }
    public static Vector4 Swizzle_x0yy(this Vector3 a) { return new Vector4(a.x, 0, a.y, a.y); }
    public static Vector4 Swizzle_x0yz(this Vector3 a) { return new Vector4(a.x, 0, a.y, a.z); }
    public static Vector4 Swizzle_x0y0(this Vector3 a) { return new Vector4(a.x, 0, a.y, 0); }
    public static Vector4 Swizzle_x0y1(this Vector3 a) { return new Vector4(a.x, 0, a.y, 1); }
    public static Vector4 Swizzle_x0zx(this Vector3 a) { return new Vector4(a.x, 0, a.z, a.x); }
    public static Vector4 Swizzle_x0zy(this Vector3 a) { return new Vector4(a.x, 0, a.z, a.y); }
    public static Vector4 Swizzle_x0zz(this Vector3 a) { return new Vector4(a.x, 0, a.z, a.z); }
    public static Vector4 Swizzle_x0z0(this Vector3 a) { return new Vector4(a.x, 0, a.z, 0); }
    public static Vector4 Swizzle_x0z1(this Vector3 a) { return new Vector4(a.x, 0, a.z, 1); }
    public static Vector4 Swizzle_x00x(this Vector3 a) { return new Vector4(a.x, 0, 0, a.x); }
    public static Vector4 Swizzle_x00y(this Vector3 a) { return new Vector4(a.x, 0, 0, a.y); }
    public static Vector4 Swizzle_x00z(this Vector3 a) { return new Vector4(a.x, 0, 0, a.z); }
    public static Vector4 Swizzle_x000(this Vector3 a) { return new Vector4(a.x, 0, 0, 0); }
    public static Vector4 Swizzle_x001(this Vector3 a) { return new Vector4(a.x, 0, 0, 1); }
    public static Vector4 Swizzle_x01x(this Vector3 a) { return new Vector4(a.x, 0, 1, a.x); }
    public static Vector4 Swizzle_x01y(this Vector3 a) { return new Vector4(a.x, 0, 1, a.y); }
    public static Vector4 Swizzle_x01z(this Vector3 a) { return new Vector4(a.x, 0, 1, a.z); }
    public static Vector4 Swizzle_x010(this Vector3 a) { return new Vector4(a.x, 0, 1, 0); }
    public static Vector4 Swizzle_x011(this Vector3 a) { return new Vector4(a.x, 0, 1, 1); }
    public static Vector4 Swizzle_x1xx(this Vector3 a) { return new Vector4(a.x, 1, a.x, a.x); }
    public static Vector4 Swizzle_x1xy(this Vector3 a) { return new Vector4(a.x, 1, a.x, a.y); }
    public static Vector4 Swizzle_x1xz(this Vector3 a) { return new Vector4(a.x, 1, a.x, a.z); }
    public static Vector4 Swizzle_x1x0(this Vector3 a) { return new Vector4(a.x, 1, a.x, 0); }
    public static Vector4 Swizzle_x1x1(this Vector3 a) { return new Vector4(a.x, 1, a.x, 1); }
    public static Vector4 Swizzle_x1yx(this Vector3 a) { return new Vector4(a.x, 1, a.y, a.x); }
    public static Vector4 Swizzle_x1yy(this Vector3 a) { return new Vector4(a.x, 1, a.y, a.y); }
    public static Vector4 Swizzle_x1yz(this Vector3 a) { return new Vector4(a.x, 1, a.y, a.z); }
    public static Vector4 Swizzle_x1y0(this Vector3 a) { return new Vector4(a.x, 1, a.y, 0); }
    public static Vector4 Swizzle_x1y1(this Vector3 a) { return new Vector4(a.x, 1, a.y, 1); }
    public static Vector4 Swizzle_x1zx(this Vector3 a) { return new Vector4(a.x, 1, a.z, a.x); }
    public static Vector4 Swizzle_x1zy(this Vector3 a) { return new Vector4(a.x, 1, a.z, a.y); }
    public static Vector4 Swizzle_x1zz(this Vector3 a) { return new Vector4(a.x, 1, a.z, a.z); }
    public static Vector4 Swizzle_x1z0(this Vector3 a) { return new Vector4(a.x, 1, a.z, 0); }
    public static Vector4 Swizzle_x1z1(this Vector3 a) { return new Vector4(a.x, 1, a.z, 1); }
    public static Vector4 Swizzle_x10x(this Vector3 a) { return new Vector4(a.x, 1, 0, a.x); }
    public static Vector4 Swizzle_x10y(this Vector3 a) { return new Vector4(a.x, 1, 0, a.y); }
    public static Vector4 Swizzle_x10z(this Vector3 a) { return new Vector4(a.x, 1, 0, a.z); }
    public static Vector4 Swizzle_x100(this Vector3 a) { return new Vector4(a.x, 1, 0, 0); }
    public static Vector4 Swizzle_x101(this Vector3 a) { return new Vector4(a.x, 1, 0, 1); }
    public static Vector4 Swizzle_x11x(this Vector3 a) { return new Vector4(a.x, 1, 1, a.x); }
    public static Vector4 Swizzle_x11y(this Vector3 a) { return new Vector4(a.x, 1, 1, a.y); }
    public static Vector4 Swizzle_x11z(this Vector3 a) { return new Vector4(a.x, 1, 1, a.z); }
    public static Vector4 Swizzle_x110(this Vector3 a) { return new Vector4(a.x, 1, 1, 0); }
    public static Vector4 Swizzle_x111(this Vector3 a) { return new Vector4(a.x, 1, 1, 1); }
    public static Vector4 Swizzle_yxxx(this Vector3 a) { return new Vector4(a.y, a.x, a.x, a.x); }
    public static Vector4 Swizzle_yxxy(this Vector3 a) { return new Vector4(a.y, a.x, a.x, a.y); }
    public static Vector4 Swizzle_yxxz(this Vector3 a) { return new Vector4(a.y, a.x, a.x, a.z); }
    public static Vector4 Swizzle_yxx0(this Vector3 a) { return new Vector4(a.y, a.x, a.x, 0); }
    public static Vector4 Swizzle_yxx1(this Vector3 a) { return new Vector4(a.y, a.x, a.x, 1); }
    public static Vector4 Swizzle_yxyx(this Vector3 a) { return new Vector4(a.y, a.x, a.y, a.x); }
    public static Vector4 Swizzle_yxyy(this Vector3 a) { return new Vector4(a.y, a.x, a.y, a.y); }
    public static Vector4 Swizzle_yxyz(this Vector3 a) { return new Vector4(a.y, a.x, a.y, a.z); }
    public static Vector4 Swizzle_yxy0(this Vector3 a) { return new Vector4(a.y, a.x, a.y, 0); }
    public static Vector4 Swizzle_yxy1(this Vector3 a) { return new Vector4(a.y, a.x, a.y, 1); }
    public static Vector4 Swizzle_yxzx(this Vector3 a) { return new Vector4(a.y, a.x, a.z, a.x); }
    public static Vector4 Swizzle_yxzy(this Vector3 a) { return new Vector4(a.y, a.x, a.z, a.y); }
    public static Vector4 Swizzle_yxzz(this Vector3 a) { return new Vector4(a.y, a.x, a.z, a.z); }
    public static Vector4 Swizzle_yxz0(this Vector3 a) { return new Vector4(a.y, a.x, a.z, 0); }
    public static Vector4 Swizzle_yxz1(this Vector3 a) { return new Vector4(a.y, a.x, a.z, 1); }
    public static Vector4 Swizzle_yx0x(this Vector3 a) { return new Vector4(a.y, a.x, 0, a.x); }
    public static Vector4 Swizzle_yx0y(this Vector3 a) { return new Vector4(a.y, a.x, 0, a.y); }
    public static Vector4 Swizzle_yx0z(this Vector3 a) { return new Vector4(a.y, a.x, 0, a.z); }
    public static Vector4 Swizzle_yx00(this Vector3 a) { return new Vector4(a.y, a.x, 0, 0); }
    public static Vector4 Swizzle_yx01(this Vector3 a) { return new Vector4(a.y, a.x, 0, 1); }
    public static Vector4 Swizzle_yx1x(this Vector3 a) { return new Vector4(a.y, a.x, 1, a.x); }
    public static Vector4 Swizzle_yx1y(this Vector3 a) { return new Vector4(a.y, a.x, 1, a.y); }
    public static Vector4 Swizzle_yx1z(this Vector3 a) { return new Vector4(a.y, a.x, 1, a.z); }
    public static Vector4 Swizzle_yx10(this Vector3 a) { return new Vector4(a.y, a.x, 1, 0); }
    public static Vector4 Swizzle_yx11(this Vector3 a) { return new Vector4(a.y, a.x, 1, 1); }
    public static Vector4 Swizzle_yyxx(this Vector3 a) { return new Vector4(a.y, a.y, a.x, a.x); }
    public static Vector4 Swizzle_yyxy(this Vector3 a) { return new Vector4(a.y, a.y, a.x, a.y); }
    public static Vector4 Swizzle_yyxz(this Vector3 a) { return new Vector4(a.y, a.y, a.x, a.z); }
    public static Vector4 Swizzle_yyx0(this Vector3 a) { return new Vector4(a.y, a.y, a.x, 0); }
    public static Vector4 Swizzle_yyx1(this Vector3 a) { return new Vector4(a.y, a.y, a.x, 1); }
    public static Vector4 Swizzle_yyyx(this Vector3 a) { return new Vector4(a.y, a.y, a.y, a.x); }
    public static Vector4 Swizzle_yyyy(this Vector3 a) { return new Vector4(a.y, a.y, a.y, a.y); }
    public static Vector4 Swizzle_yyyz(this Vector3 a) { return new Vector4(a.y, a.y, a.y, a.z); }
    public static Vector4 Swizzle_yyy0(this Vector3 a) { return new Vector4(a.y, a.y, a.y, 0); }
    public static Vector4 Swizzle_yyy1(this Vector3 a) { return new Vector4(a.y, a.y, a.y, 1); }
    public static Vector4 Swizzle_yyzx(this Vector3 a) { return new Vector4(a.y, a.y, a.z, a.x); }
    public static Vector4 Swizzle_yyzy(this Vector3 a) { return new Vector4(a.y, a.y, a.z, a.y); }
    public static Vector4 Swizzle_yyzz(this Vector3 a) { return new Vector4(a.y, a.y, a.z, a.z); }
    public static Vector4 Swizzle_yyz0(this Vector3 a) { return new Vector4(a.y, a.y, a.z, 0); }
    public static Vector4 Swizzle_yyz1(this Vector3 a) { return new Vector4(a.y, a.y, a.z, 1); }
    public static Vector4 Swizzle_yy0x(this Vector3 a) { return new Vector4(a.y, a.y, 0, a.x); }
    public static Vector4 Swizzle_yy0y(this Vector3 a) { return new Vector4(a.y, a.y, 0, a.y); }
    public static Vector4 Swizzle_yy0z(this Vector3 a) { return new Vector4(a.y, a.y, 0, a.z); }
    public static Vector4 Swizzle_yy00(this Vector3 a) { return new Vector4(a.y, a.y, 0, 0); }
    public static Vector4 Swizzle_yy01(this Vector3 a) { return new Vector4(a.y, a.y, 0, 1); }
    public static Vector4 Swizzle_yy1x(this Vector3 a) { return new Vector4(a.y, a.y, 1, a.x); }
    public static Vector4 Swizzle_yy1y(this Vector3 a) { return new Vector4(a.y, a.y, 1, a.y); }
    public static Vector4 Swizzle_yy1z(this Vector3 a) { return new Vector4(a.y, a.y, 1, a.z); }
    public static Vector4 Swizzle_yy10(this Vector3 a) { return new Vector4(a.y, a.y, 1, 0); }
    public static Vector4 Swizzle_yy11(this Vector3 a) { return new Vector4(a.y, a.y, 1, 1); }
    public static Vector4 Swizzle_yzxx(this Vector3 a) { return new Vector4(a.y, a.z, a.x, a.x); }
    public static Vector4 Swizzle_yzxy(this Vector3 a) { return new Vector4(a.y, a.z, a.x, a.y); }
    public static Vector4 Swizzle_yzxz(this Vector3 a) { return new Vector4(a.y, a.z, a.x, a.z); }
    public static Vector4 Swizzle_yzx0(this Vector3 a) { return new Vector4(a.y, a.z, a.x, 0); }
    public static Vector4 Swizzle_yzx1(this Vector3 a) { return new Vector4(a.y, a.z, a.x, 1); }
    public static Vector4 Swizzle_yzyx(this Vector3 a) { return new Vector4(a.y, a.z, a.y, a.x); }
    public static Vector4 Swizzle_yzyy(this Vector3 a) { return new Vector4(a.y, a.z, a.y, a.y); }
    public static Vector4 Swizzle_yzyz(this Vector3 a) { return new Vector4(a.y, a.z, a.y, a.z); }
    public static Vector4 Swizzle_yzy0(this Vector3 a) { return new Vector4(a.y, a.z, a.y, 0); }
    public static Vector4 Swizzle_yzy1(this Vector3 a) { return new Vector4(a.y, a.z, a.y, 1); }
    public static Vector4 Swizzle_yzzx(this Vector3 a) { return new Vector4(a.y, a.z, a.z, a.x); }
    public static Vector4 Swizzle_yzzy(this Vector3 a) { return new Vector4(a.y, a.z, a.z, a.y); }
    public static Vector4 Swizzle_yzzz(this Vector3 a) { return new Vector4(a.y, a.z, a.z, a.z); }
    public static Vector4 Swizzle_yzz0(this Vector3 a) { return new Vector4(a.y, a.z, a.z, 0); }
    public static Vector4 Swizzle_yzz1(this Vector3 a) { return new Vector4(a.y, a.z, a.z, 1); }
    public static Vector4 Swizzle_yz0x(this Vector3 a) { return new Vector4(a.y, a.z, 0, a.x); }
    public static Vector4 Swizzle_yz0y(this Vector3 a) { return new Vector4(a.y, a.z, 0, a.y); }
    public static Vector4 Swizzle_yz0z(this Vector3 a) { return new Vector4(a.y, a.z, 0, a.z); }
    public static Vector4 Swizzle_yz00(this Vector3 a) { return new Vector4(a.y, a.z, 0, 0); }
    public static Vector4 Swizzle_yz01(this Vector3 a) { return new Vector4(a.y, a.z, 0, 1); }
    public static Vector4 Swizzle_yz1x(this Vector3 a) { return new Vector4(a.y, a.z, 1, a.x); }
    public static Vector4 Swizzle_yz1y(this Vector3 a) { return new Vector4(a.y, a.z, 1, a.y); }
    public static Vector4 Swizzle_yz1z(this Vector3 a) { return new Vector4(a.y, a.z, 1, a.z); }
    public static Vector4 Swizzle_yz10(this Vector3 a) { return new Vector4(a.y, a.z, 1, 0); }
    public static Vector4 Swizzle_yz11(this Vector3 a) { return new Vector4(a.y, a.z, 1, 1); }
    public static Vector4 Swizzle_y0xx(this Vector3 a) { return new Vector4(a.y, 0, a.x, a.x); }
    public static Vector4 Swizzle_y0xy(this Vector3 a) { return new Vector4(a.y, 0, a.x, a.y); }
    public static Vector4 Swizzle_y0xz(this Vector3 a) { return new Vector4(a.y, 0, a.x, a.z); }
    public static Vector4 Swizzle_y0x0(this Vector3 a) { return new Vector4(a.y, 0, a.x, 0); }
    public static Vector4 Swizzle_y0x1(this Vector3 a) { return new Vector4(a.y, 0, a.x, 1); }
    public static Vector4 Swizzle_y0yx(this Vector3 a) { return new Vector4(a.y, 0, a.y, a.x); }
    public static Vector4 Swizzle_y0yy(this Vector3 a) { return new Vector4(a.y, 0, a.y, a.y); }
    public static Vector4 Swizzle_y0yz(this Vector3 a) { return new Vector4(a.y, 0, a.y, a.z); }
    public static Vector4 Swizzle_y0y0(this Vector3 a) { return new Vector4(a.y, 0, a.y, 0); }
    public static Vector4 Swizzle_y0y1(this Vector3 a) { return new Vector4(a.y, 0, a.y, 1); }
    public static Vector4 Swizzle_y0zx(this Vector3 a) { return new Vector4(a.y, 0, a.z, a.x); }
    public static Vector4 Swizzle_y0zy(this Vector3 a) { return new Vector4(a.y, 0, a.z, a.y); }
    public static Vector4 Swizzle_y0zz(this Vector3 a) { return new Vector4(a.y, 0, a.z, a.z); }
    public static Vector4 Swizzle_y0z0(this Vector3 a) { return new Vector4(a.y, 0, a.z, 0); }
    public static Vector4 Swizzle_y0z1(this Vector3 a) { return new Vector4(a.y, 0, a.z, 1); }
    public static Vector4 Swizzle_y00x(this Vector3 a) { return new Vector4(a.y, 0, 0, a.x); }
    public static Vector4 Swizzle_y00y(this Vector3 a) { return new Vector4(a.y, 0, 0, a.y); }
    public static Vector4 Swizzle_y00z(this Vector3 a) { return new Vector4(a.y, 0, 0, a.z); }
    public static Vector4 Swizzle_y000(this Vector3 a) { return new Vector4(a.y, 0, 0, 0); }
    public static Vector4 Swizzle_y001(this Vector3 a) { return new Vector4(a.y, 0, 0, 1); }
    public static Vector4 Swizzle_y01x(this Vector3 a) { return new Vector4(a.y, 0, 1, a.x); }
    public static Vector4 Swizzle_y01y(this Vector3 a) { return new Vector4(a.y, 0, 1, a.y); }
    public static Vector4 Swizzle_y01z(this Vector3 a) { return new Vector4(a.y, 0, 1, a.z); }
    public static Vector4 Swizzle_y010(this Vector3 a) { return new Vector4(a.y, 0, 1, 0); }
    public static Vector4 Swizzle_y011(this Vector3 a) { return new Vector4(a.y, 0, 1, 1); }
    public static Vector4 Swizzle_y1xx(this Vector3 a) { return new Vector4(a.y, 1, a.x, a.x); }
    public static Vector4 Swizzle_y1xy(this Vector3 a) { return new Vector4(a.y, 1, a.x, a.y); }
    public static Vector4 Swizzle_y1xz(this Vector3 a) { return new Vector4(a.y, 1, a.x, a.z); }
    public static Vector4 Swizzle_y1x0(this Vector3 a) { return new Vector4(a.y, 1, a.x, 0); }
    public static Vector4 Swizzle_y1x1(this Vector3 a) { return new Vector4(a.y, 1, a.x, 1); }
    public static Vector4 Swizzle_y1yx(this Vector3 a) { return new Vector4(a.y, 1, a.y, a.x); }
    public static Vector4 Swizzle_y1yy(this Vector3 a) { return new Vector4(a.y, 1, a.y, a.y); }
    public static Vector4 Swizzle_y1yz(this Vector3 a) { return new Vector4(a.y, 1, a.y, a.z); }
    public static Vector4 Swizzle_y1y0(this Vector3 a) { return new Vector4(a.y, 1, a.y, 0); }
    public static Vector4 Swizzle_y1y1(this Vector3 a) { return new Vector4(a.y, 1, a.y, 1); }
    public static Vector4 Swizzle_y1zx(this Vector3 a) { return new Vector4(a.y, 1, a.z, a.x); }
    public static Vector4 Swizzle_y1zy(this Vector3 a) { return new Vector4(a.y, 1, a.z, a.y); }
    public static Vector4 Swizzle_y1zz(this Vector3 a) { return new Vector4(a.y, 1, a.z, a.z); }
    public static Vector4 Swizzle_y1z0(this Vector3 a) { return new Vector4(a.y, 1, a.z, 0); }
    public static Vector4 Swizzle_y1z1(this Vector3 a) { return new Vector4(a.y, 1, a.z, 1); }
    public static Vector4 Swizzle_y10x(this Vector3 a) { return new Vector4(a.y, 1, 0, a.x); }
    public static Vector4 Swizzle_y10y(this Vector3 a) { return new Vector4(a.y, 1, 0, a.y); }
    public static Vector4 Swizzle_y10z(this Vector3 a) { return new Vector4(a.y, 1, 0, a.z); }
    public static Vector4 Swizzle_y100(this Vector3 a) { return new Vector4(a.y, 1, 0, 0); }
    public static Vector4 Swizzle_y101(this Vector3 a) { return new Vector4(a.y, 1, 0, 1); }
    public static Vector4 Swizzle_y11x(this Vector3 a) { return new Vector4(a.y, 1, 1, a.x); }
    public static Vector4 Swizzle_y11y(this Vector3 a) { return new Vector4(a.y, 1, 1, a.y); }
    public static Vector4 Swizzle_y11z(this Vector3 a) { return new Vector4(a.y, 1, 1, a.z); }
    public static Vector4 Swizzle_y110(this Vector3 a) { return new Vector4(a.y, 1, 1, 0); }
    public static Vector4 Swizzle_y111(this Vector3 a) { return new Vector4(a.y, 1, 1, 1); }
    public static Vector4 Swizzle_zxxx(this Vector3 a) { return new Vector4(a.z, a.x, a.x, a.x); }
    public static Vector4 Swizzle_zxxy(this Vector3 a) { return new Vector4(a.z, a.x, a.x, a.y); }
    public static Vector4 Swizzle_zxxz(this Vector3 a) { return new Vector4(a.z, a.x, a.x, a.z); }
    public static Vector4 Swizzle_zxx0(this Vector3 a) { return new Vector4(a.z, a.x, a.x, 0); }
    public static Vector4 Swizzle_zxx1(this Vector3 a) { return new Vector4(a.z, a.x, a.x, 1); }
    public static Vector4 Swizzle_zxyx(this Vector3 a) { return new Vector4(a.z, a.x, a.y, a.x); }
    public static Vector4 Swizzle_zxyy(this Vector3 a) { return new Vector4(a.z, a.x, a.y, a.y); }
    public static Vector4 Swizzle_zxyz(this Vector3 a) { return new Vector4(a.z, a.x, a.y, a.z); }
    public static Vector4 Swizzle_zxy0(this Vector3 a) { return new Vector4(a.z, a.x, a.y, 0); }
    public static Vector4 Swizzle_zxy1(this Vector3 a) { return new Vector4(a.z, a.x, a.y, 1); }
    public static Vector4 Swizzle_zxzx(this Vector3 a) { return new Vector4(a.z, a.x, a.z, a.x); }
    public static Vector4 Swizzle_zxzy(this Vector3 a) { return new Vector4(a.z, a.x, a.z, a.y); }
    public static Vector4 Swizzle_zxzz(this Vector3 a) { return new Vector4(a.z, a.x, a.z, a.z); }
    public static Vector4 Swizzle_zxz0(this Vector3 a) { return new Vector4(a.z, a.x, a.z, 0); }
    public static Vector4 Swizzle_zxz1(this Vector3 a) { return new Vector4(a.z, a.x, a.z, 1); }
    public static Vector4 Swizzle_zx0x(this Vector3 a) { return new Vector4(a.z, a.x, 0, a.x); }
    public static Vector4 Swizzle_zx0y(this Vector3 a) { return new Vector4(a.z, a.x, 0, a.y); }
    public static Vector4 Swizzle_zx0z(this Vector3 a) { return new Vector4(a.z, a.x, 0, a.z); }
    public static Vector4 Swizzle_zx00(this Vector3 a) { return new Vector4(a.z, a.x, 0, 0); }
    public static Vector4 Swizzle_zx01(this Vector3 a) { return new Vector4(a.z, a.x, 0, 1); }
    public static Vector4 Swizzle_zx1x(this Vector3 a) { return new Vector4(a.z, a.x, 1, a.x); }
    public static Vector4 Swizzle_zx1y(this Vector3 a) { return new Vector4(a.z, a.x, 1, a.y); }
    public static Vector4 Swizzle_zx1z(this Vector3 a) { return new Vector4(a.z, a.x, 1, a.z); }
    public static Vector4 Swizzle_zx10(this Vector3 a) { return new Vector4(a.z, a.x, 1, 0); }
    public static Vector4 Swizzle_zx11(this Vector3 a) { return new Vector4(a.z, a.x, 1, 1); }
    public static Vector4 Swizzle_zyxx(this Vector3 a) { return new Vector4(a.z, a.y, a.x, a.x); }
    public static Vector4 Swizzle_zyxy(this Vector3 a) { return new Vector4(a.z, a.y, a.x, a.y); }
    public static Vector4 Swizzle_zyxz(this Vector3 a) { return new Vector4(a.z, a.y, a.x, a.z); }
    public static Vector4 Swizzle_zyx0(this Vector3 a) { return new Vector4(a.z, a.y, a.x, 0); }
    public static Vector4 Swizzle_zyx1(this Vector3 a) { return new Vector4(a.z, a.y, a.x, 1); }
    public static Vector4 Swizzle_zyyx(this Vector3 a) { return new Vector4(a.z, a.y, a.y, a.x); }
    public static Vector4 Swizzle_zyyy(this Vector3 a) { return new Vector4(a.z, a.y, a.y, a.y); }
    public static Vector4 Swizzle_zyyz(this Vector3 a) { return new Vector4(a.z, a.y, a.y, a.z); }
    public static Vector4 Swizzle_zyy0(this Vector3 a) { return new Vector4(a.z, a.y, a.y, 0); }
    public static Vector4 Swizzle_zyy1(this Vector3 a) { return new Vector4(a.z, a.y, a.y, 1); }
    public static Vector4 Swizzle_zyzx(this Vector3 a) { return new Vector4(a.z, a.y, a.z, a.x); }
    public static Vector4 Swizzle_zyzy(this Vector3 a) { return new Vector4(a.z, a.y, a.z, a.y); }
    public static Vector4 Swizzle_zyzz(this Vector3 a) { return new Vector4(a.z, a.y, a.z, a.z); }
    public static Vector4 Swizzle_zyz0(this Vector3 a) { return new Vector4(a.z, a.y, a.z, 0); }
    public static Vector4 Swizzle_zyz1(this Vector3 a) { return new Vector4(a.z, a.y, a.z, 1); }
    public static Vector4 Swizzle_zy0x(this Vector3 a) { return new Vector4(a.z, a.y, 0, a.x); }
    public static Vector4 Swizzle_zy0y(this Vector3 a) { return new Vector4(a.z, a.y, 0, a.y); }
    public static Vector4 Swizzle_zy0z(this Vector3 a) { return new Vector4(a.z, a.y, 0, a.z); }
    public static Vector4 Swizzle_zy00(this Vector3 a) { return new Vector4(a.z, a.y, 0, 0); }
    public static Vector4 Swizzle_zy01(this Vector3 a) { return new Vector4(a.z, a.y, 0, 1); }
    public static Vector4 Swizzle_zy1x(this Vector3 a) { return new Vector4(a.z, a.y, 1, a.x); }
    public static Vector4 Swizzle_zy1y(this Vector3 a) { return new Vector4(a.z, a.y, 1, a.y); }
    public static Vector4 Swizzle_zy1z(this Vector3 a) { return new Vector4(a.z, a.y, 1, a.z); }
    public static Vector4 Swizzle_zy10(this Vector3 a) { return new Vector4(a.z, a.y, 1, 0); }
    public static Vector4 Swizzle_zy11(this Vector3 a) { return new Vector4(a.z, a.y, 1, 1); }
    public static Vector4 Swizzle_zzxx(this Vector3 a) { return new Vector4(a.z, a.z, a.x, a.x); }
    public static Vector4 Swizzle_zzxy(this Vector3 a) { return new Vector4(a.z, a.z, a.x, a.y); }
    public static Vector4 Swizzle_zzxz(this Vector3 a) { return new Vector4(a.z, a.z, a.x, a.z); }
    public static Vector4 Swizzle_zzx0(this Vector3 a) { return new Vector4(a.z, a.z, a.x, 0); }
    public static Vector4 Swizzle_zzx1(this Vector3 a) { return new Vector4(a.z, a.z, a.x, 1); }
    public static Vector4 Swizzle_zzyx(this Vector3 a) { return new Vector4(a.z, a.z, a.y, a.x); }
    public static Vector4 Swizzle_zzyy(this Vector3 a) { return new Vector4(a.z, a.z, a.y, a.y); }
    public static Vector4 Swizzle_zzyz(this Vector3 a) { return new Vector4(a.z, a.z, a.y, a.z); }
    public static Vector4 Swizzle_zzy0(this Vector3 a) { return new Vector4(a.z, a.z, a.y, 0); }
    public static Vector4 Swizzle_zzy1(this Vector3 a) { return new Vector4(a.z, a.z, a.y, 1); }
    public static Vector4 Swizzle_zzzx(this Vector3 a) { return new Vector4(a.z, a.z, a.z, a.x); }
    public static Vector4 Swizzle_zzzy(this Vector3 a) { return new Vector4(a.z, a.z, a.z, a.y); }
    public static Vector4 Swizzle_zzzz(this Vector3 a) { return new Vector4(a.z, a.z, a.z, a.z); }
    public static Vector4 Swizzle_zzz0(this Vector3 a) { return new Vector4(a.z, a.z, a.z, 0); }
    public static Vector4 Swizzle_zzz1(this Vector3 a) { return new Vector4(a.z, a.z, a.z, 1); }
    public static Vector4 Swizzle_zz0x(this Vector3 a) { return new Vector4(a.z, a.z, 0, a.x); }
    public static Vector4 Swizzle_zz0y(this Vector3 a) { return new Vector4(a.z, a.z, 0, a.y); }
    public static Vector4 Swizzle_zz0z(this Vector3 a) { return new Vector4(a.z, a.z, 0, a.z); }
    public static Vector4 Swizzle_zz00(this Vector3 a) { return new Vector4(a.z, a.z, 0, 0); }
    public static Vector4 Swizzle_zz01(this Vector3 a) { return new Vector4(a.z, a.z, 0, 1); }
    public static Vector4 Swizzle_zz1x(this Vector3 a) { return new Vector4(a.z, a.z, 1, a.x); }
    public static Vector4 Swizzle_zz1y(this Vector3 a) { return new Vector4(a.z, a.z, 1, a.y); }
    public static Vector4 Swizzle_zz1z(this Vector3 a) { return new Vector4(a.z, a.z, 1, a.z); }
    public static Vector4 Swizzle_zz10(this Vector3 a) { return new Vector4(a.z, a.z, 1, 0); }
    public static Vector4 Swizzle_zz11(this Vector3 a) { return new Vector4(a.z, a.z, 1, 1); }
    public static Vector4 Swizzle_z0xx(this Vector3 a) { return new Vector4(a.z, 0, a.x, a.x); }
    public static Vector4 Swizzle_z0xy(this Vector3 a) { return new Vector4(a.z, 0, a.x, a.y); }
    public static Vector4 Swizzle_z0xz(this Vector3 a) { return new Vector4(a.z, 0, a.x, a.z); }
    public static Vector4 Swizzle_z0x0(this Vector3 a) { return new Vector4(a.z, 0, a.x, 0); }
    public static Vector4 Swizzle_z0x1(this Vector3 a) { return new Vector4(a.z, 0, a.x, 1); }
    public static Vector4 Swizzle_z0yx(this Vector3 a) { return new Vector4(a.z, 0, a.y, a.x); }
    public static Vector4 Swizzle_z0yy(this Vector3 a) { return new Vector4(a.z, 0, a.y, a.y); }
    public static Vector4 Swizzle_z0yz(this Vector3 a) { return new Vector4(a.z, 0, a.y, a.z); }
    public static Vector4 Swizzle_z0y0(this Vector3 a) { return new Vector4(a.z, 0, a.y, 0); }
    public static Vector4 Swizzle_z0y1(this Vector3 a) { return new Vector4(a.z, 0, a.y, 1); }
    public static Vector4 Swizzle_z0zx(this Vector3 a) { return new Vector4(a.z, 0, a.z, a.x); }
    public static Vector4 Swizzle_z0zy(this Vector3 a) { return new Vector4(a.z, 0, a.z, a.y); }
    public static Vector4 Swizzle_z0zz(this Vector3 a) { return new Vector4(a.z, 0, a.z, a.z); }
    public static Vector4 Swizzle_z0z0(this Vector3 a) { return new Vector4(a.z, 0, a.z, 0); }
    public static Vector4 Swizzle_z0z1(this Vector3 a) { return new Vector4(a.z, 0, a.z, 1); }
    public static Vector4 Swizzle_z00x(this Vector3 a) { return new Vector4(a.z, 0, 0, a.x); }
    public static Vector4 Swizzle_z00y(this Vector3 a) { return new Vector4(a.z, 0, 0, a.y); }
    public static Vector4 Swizzle_z00z(this Vector3 a) { return new Vector4(a.z, 0, 0, a.z); }
    public static Vector4 Swizzle_z000(this Vector3 a) { return new Vector4(a.z, 0, 0, 0); }
    public static Vector4 Swizzle_z001(this Vector3 a) { return new Vector4(a.z, 0, 0, 1); }
    public static Vector4 Swizzle_z01x(this Vector3 a) { return new Vector4(a.z, 0, 1, a.x); }
    public static Vector4 Swizzle_z01y(this Vector3 a) { return new Vector4(a.z, 0, 1, a.y); }
    public static Vector4 Swizzle_z01z(this Vector3 a) { return new Vector4(a.z, 0, 1, a.z); }
    public static Vector4 Swizzle_z010(this Vector3 a) { return new Vector4(a.z, 0, 1, 0); }
    public static Vector4 Swizzle_z011(this Vector3 a) { return new Vector4(a.z, 0, 1, 1); }
    public static Vector4 Swizzle_z1xx(this Vector3 a) { return new Vector4(a.z, 1, a.x, a.x); }
    public static Vector4 Swizzle_z1xy(this Vector3 a) { return new Vector4(a.z, 1, a.x, a.y); }
    public static Vector4 Swizzle_z1xz(this Vector3 a) { return new Vector4(a.z, 1, a.x, a.z); }
    public static Vector4 Swizzle_z1x0(this Vector3 a) { return new Vector4(a.z, 1, a.x, 0); }
    public static Vector4 Swizzle_z1x1(this Vector3 a) { return new Vector4(a.z, 1, a.x, 1); }
    public static Vector4 Swizzle_z1yx(this Vector3 a) { return new Vector4(a.z, 1, a.y, a.x); }
    public static Vector4 Swizzle_z1yy(this Vector3 a) { return new Vector4(a.z, 1, a.y, a.y); }
    public static Vector4 Swizzle_z1yz(this Vector3 a) { return new Vector4(a.z, 1, a.y, a.z); }
    public static Vector4 Swizzle_z1y0(this Vector3 a) { return new Vector4(a.z, 1, a.y, 0); }
    public static Vector4 Swizzle_z1y1(this Vector3 a) { return new Vector4(a.z, 1, a.y, 1); }
    public static Vector4 Swizzle_z1zx(this Vector3 a) { return new Vector4(a.z, 1, a.z, a.x); }
    public static Vector4 Swizzle_z1zy(this Vector3 a) { return new Vector4(a.z, 1, a.z, a.y); }
    public static Vector4 Swizzle_z1zz(this Vector3 a) { return new Vector4(a.z, 1, a.z, a.z); }
    public static Vector4 Swizzle_z1z0(this Vector3 a) { return new Vector4(a.z, 1, a.z, 0); }
    public static Vector4 Swizzle_z1z1(this Vector3 a) { return new Vector4(a.z, 1, a.z, 1); }
    public static Vector4 Swizzle_z10x(this Vector3 a) { return new Vector4(a.z, 1, 0, a.x); }
    public static Vector4 Swizzle_z10y(this Vector3 a) { return new Vector4(a.z, 1, 0, a.y); }
    public static Vector4 Swizzle_z10z(this Vector3 a) { return new Vector4(a.z, 1, 0, a.z); }
    public static Vector4 Swizzle_z100(this Vector3 a) { return new Vector4(a.z, 1, 0, 0); }
    public static Vector4 Swizzle_z101(this Vector3 a) { return new Vector4(a.z, 1, 0, 1); }
    public static Vector4 Swizzle_z11x(this Vector3 a) { return new Vector4(a.z, 1, 1, a.x); }
    public static Vector4 Swizzle_z11y(this Vector3 a) { return new Vector4(a.z, 1, 1, a.y); }
    public static Vector4 Swizzle_z11z(this Vector3 a) { return new Vector4(a.z, 1, 1, a.z); }
    public static Vector4 Swizzle_z110(this Vector3 a) { return new Vector4(a.z, 1, 1, 0); }
    public static Vector4 Swizzle_z111(this Vector3 a) { return new Vector4(a.z, 1, 1, 1); }
    public static Vector4 Swizzle_0xxx(this Vector3 a) { return new Vector4(0, a.x, a.x, a.x); }
    public static Vector4 Swizzle_0xxy(this Vector3 a) { return new Vector4(0, a.x, a.x, a.y); }
    public static Vector4 Swizzle_0xxz(this Vector3 a) { return new Vector4(0, a.x, a.x, a.z); }
    public static Vector4 Swizzle_0xx0(this Vector3 a) { return new Vector4(0, a.x, a.x, 0); }
    public static Vector4 Swizzle_0xx1(this Vector3 a) { return new Vector4(0, a.x, a.x, 1); }
    public static Vector4 Swizzle_0xyx(this Vector3 a) { return new Vector4(0, a.x, a.y, a.x); }
    public static Vector4 Swizzle_0xyy(this Vector3 a) { return new Vector4(0, a.x, a.y, a.y); }
    public static Vector4 Swizzle_0xyz(this Vector3 a) { return new Vector4(0, a.x, a.y, a.z); }
    public static Vector4 Swizzle_0xy0(this Vector3 a) { return new Vector4(0, a.x, a.y, 0); }
    public static Vector4 Swizzle_0xy1(this Vector3 a) { return new Vector4(0, a.x, a.y, 1); }
    public static Vector4 Swizzle_0xzx(this Vector3 a) { return new Vector4(0, a.x, a.z, a.x); }
    public static Vector4 Swizzle_0xzy(this Vector3 a) { return new Vector4(0, a.x, a.z, a.y); }
    public static Vector4 Swizzle_0xzz(this Vector3 a) { return new Vector4(0, a.x, a.z, a.z); }
    public static Vector4 Swizzle_0xz0(this Vector3 a) { return new Vector4(0, a.x, a.z, 0); }
    public static Vector4 Swizzle_0xz1(this Vector3 a) { return new Vector4(0, a.x, a.z, 1); }
    public static Vector4 Swizzle_0x0x(this Vector3 a) { return new Vector4(0, a.x, 0, a.x); }
    public static Vector4 Swizzle_0x0y(this Vector3 a) { return new Vector4(0, a.x, 0, a.y); }
    public static Vector4 Swizzle_0x0z(this Vector3 a) { return new Vector4(0, a.x, 0, a.z); }
    public static Vector4 Swizzle_0x00(this Vector3 a) { return new Vector4(0, a.x, 0, 0); }
    public static Vector4 Swizzle_0x01(this Vector3 a) { return new Vector4(0, a.x, 0, 1); }
    public static Vector4 Swizzle_0x1x(this Vector3 a) { return new Vector4(0, a.x, 1, a.x); }
    public static Vector4 Swizzle_0x1y(this Vector3 a) { return new Vector4(0, a.x, 1, a.y); }
    public static Vector4 Swizzle_0x1z(this Vector3 a) { return new Vector4(0, a.x, 1, a.z); }
    public static Vector4 Swizzle_0x10(this Vector3 a) { return new Vector4(0, a.x, 1, 0); }
    public static Vector4 Swizzle_0x11(this Vector3 a) { return new Vector4(0, a.x, 1, 1); }
    public static Vector4 Swizzle_0yxx(this Vector3 a) { return new Vector4(0, a.y, a.x, a.x); }
    public static Vector4 Swizzle_0yxy(this Vector3 a) { return new Vector4(0, a.y, a.x, a.y); }
    public static Vector4 Swizzle_0yxz(this Vector3 a) { return new Vector4(0, a.y, a.x, a.z); }
    public static Vector4 Swizzle_0yx0(this Vector3 a) { return new Vector4(0, a.y, a.x, 0); }
    public static Vector4 Swizzle_0yx1(this Vector3 a) { return new Vector4(0, a.y, a.x, 1); }
    public static Vector4 Swizzle_0yyx(this Vector3 a) { return new Vector4(0, a.y, a.y, a.x); }
    public static Vector4 Swizzle_0yyy(this Vector3 a) { return new Vector4(0, a.y, a.y, a.y); }
    public static Vector4 Swizzle_0yyz(this Vector3 a) { return new Vector4(0, a.y, a.y, a.z); }
    public static Vector4 Swizzle_0yy0(this Vector3 a) { return new Vector4(0, a.y, a.y, 0); }
    public static Vector4 Swizzle_0yy1(this Vector3 a) { return new Vector4(0, a.y, a.y, 1); }
    public static Vector4 Swizzle_0yzx(this Vector3 a) { return new Vector4(0, a.y, a.z, a.x); }
    public static Vector4 Swizzle_0yzy(this Vector3 a) { return new Vector4(0, a.y, a.z, a.y); }
    public static Vector4 Swizzle_0yzz(this Vector3 a) { return new Vector4(0, a.y, a.z, a.z); }
    public static Vector4 Swizzle_0yz0(this Vector3 a) { return new Vector4(0, a.y, a.z, 0); }
    public static Vector4 Swizzle_0yz1(this Vector3 a) { return new Vector4(0, a.y, a.z, 1); }
    public static Vector4 Swizzle_0y0x(this Vector3 a) { return new Vector4(0, a.y, 0, a.x); }
    public static Vector4 Swizzle_0y0y(this Vector3 a) { return new Vector4(0, a.y, 0, a.y); }
    public static Vector4 Swizzle_0y0z(this Vector3 a) { return new Vector4(0, a.y, 0, a.z); }
    public static Vector4 Swizzle_0y00(this Vector3 a) { return new Vector4(0, a.y, 0, 0); }
    public static Vector4 Swizzle_0y01(this Vector3 a) { return new Vector4(0, a.y, 0, 1); }
    public static Vector4 Swizzle_0y1x(this Vector3 a) { return new Vector4(0, a.y, 1, a.x); }
    public static Vector4 Swizzle_0y1y(this Vector3 a) { return new Vector4(0, a.y, 1, a.y); }
    public static Vector4 Swizzle_0y1z(this Vector3 a) { return new Vector4(0, a.y, 1, a.z); }
    public static Vector4 Swizzle_0y10(this Vector3 a) { return new Vector4(0, a.y, 1, 0); }
    public static Vector4 Swizzle_0y11(this Vector3 a) { return new Vector4(0, a.y, 1, 1); }
    public static Vector4 Swizzle_0zxx(this Vector3 a) { return new Vector4(0, a.z, a.x, a.x); }
    public static Vector4 Swizzle_0zxy(this Vector3 a) { return new Vector4(0, a.z, a.x, a.y); }
    public static Vector4 Swizzle_0zxz(this Vector3 a) { return new Vector4(0, a.z, a.x, a.z); }
    public static Vector4 Swizzle_0zx0(this Vector3 a) { return new Vector4(0, a.z, a.x, 0); }
    public static Vector4 Swizzle_0zx1(this Vector3 a) { return new Vector4(0, a.z, a.x, 1); }
    public static Vector4 Swizzle_0zyx(this Vector3 a) { return new Vector4(0, a.z, a.y, a.x); }
    public static Vector4 Swizzle_0zyy(this Vector3 a) { return new Vector4(0, a.z, a.y, a.y); }
    public static Vector4 Swizzle_0zyz(this Vector3 a) { return new Vector4(0, a.z, a.y, a.z); }
    public static Vector4 Swizzle_0zy0(this Vector3 a) { return new Vector4(0, a.z, a.y, 0); }
    public static Vector4 Swizzle_0zy1(this Vector3 a) { return new Vector4(0, a.z, a.y, 1); }
    public static Vector4 Swizzle_0zzx(this Vector3 a) { return new Vector4(0, a.z, a.z, a.x); }
    public static Vector4 Swizzle_0zzy(this Vector3 a) { return new Vector4(0, a.z, a.z, a.y); }
    public static Vector4 Swizzle_0zzz(this Vector3 a) { return new Vector4(0, a.z, a.z, a.z); }
    public static Vector4 Swizzle_0zz0(this Vector3 a) { return new Vector4(0, a.z, a.z, 0); }
    public static Vector4 Swizzle_0zz1(this Vector3 a) { return new Vector4(0, a.z, a.z, 1); }
    public static Vector4 Swizzle_0z0x(this Vector3 a) { return new Vector4(0, a.z, 0, a.x); }
    public static Vector4 Swizzle_0z0y(this Vector3 a) { return new Vector4(0, a.z, 0, a.y); }
    public static Vector4 Swizzle_0z0z(this Vector3 a) { return new Vector4(0, a.z, 0, a.z); }
    public static Vector4 Swizzle_0z00(this Vector3 a) { return new Vector4(0, a.z, 0, 0); }
    public static Vector4 Swizzle_0z01(this Vector3 a) { return new Vector4(0, a.z, 0, 1); }
    public static Vector4 Swizzle_0z1x(this Vector3 a) { return new Vector4(0, a.z, 1, a.x); }
    public static Vector4 Swizzle_0z1y(this Vector3 a) { return new Vector4(0, a.z, 1, a.y); }
    public static Vector4 Swizzle_0z1z(this Vector3 a) { return new Vector4(0, a.z, 1, a.z); }
    public static Vector4 Swizzle_0z10(this Vector3 a) { return new Vector4(0, a.z, 1, 0); }
    public static Vector4 Swizzle_0z11(this Vector3 a) { return new Vector4(0, a.z, 1, 1); }
    public static Vector4 Swizzle_00xx(this Vector3 a) { return new Vector4(0, 0, a.x, a.x); }
    public static Vector4 Swizzle_00xy(this Vector3 a) { return new Vector4(0, 0, a.x, a.y); }
    public static Vector4 Swizzle_00xz(this Vector3 a) { return new Vector4(0, 0, a.x, a.z); }
    public static Vector4 Swizzle_00x0(this Vector3 a) { return new Vector4(0, 0, a.x, 0); }
    public static Vector4 Swizzle_00x1(this Vector3 a) { return new Vector4(0, 0, a.x, 1); }
    public static Vector4 Swizzle_00yx(this Vector3 a) { return new Vector4(0, 0, a.y, a.x); }
    public static Vector4 Swizzle_00yy(this Vector3 a) { return new Vector4(0, 0, a.y, a.y); }
    public static Vector4 Swizzle_00yz(this Vector3 a) { return new Vector4(0, 0, a.y, a.z); }
    public static Vector4 Swizzle_00y0(this Vector3 a) { return new Vector4(0, 0, a.y, 0); }
    public static Vector4 Swizzle_00y1(this Vector3 a) { return new Vector4(0, 0, a.y, 1); }
    public static Vector4 Swizzle_00zx(this Vector3 a) { return new Vector4(0, 0, a.z, a.x); }
    public static Vector4 Swizzle_00zy(this Vector3 a) { return new Vector4(0, 0, a.z, a.y); }
    public static Vector4 Swizzle_00zz(this Vector3 a) { return new Vector4(0, 0, a.z, a.z); }
    public static Vector4 Swizzle_00z0(this Vector3 a) { return new Vector4(0, 0, a.z, 0); }
    public static Vector4 Swizzle_00z1(this Vector3 a) { return new Vector4(0, 0, a.z, 1); }
    public static Vector4 Swizzle_000x(this Vector3 a) { return new Vector4(0, 0, 0, a.x); }
    public static Vector4 Swizzle_000y(this Vector3 a) { return new Vector4(0, 0, 0, a.y); }
    public static Vector4 Swizzle_000z(this Vector3 a) { return new Vector4(0, 0, 0, a.z); }
    public static Vector4 Swizzle_0000(this Vector3 a) { return new Vector4(0, 0, 0, 0); }
    public static Vector4 Swizzle_0001(this Vector3 a) { return new Vector4(0, 0, 0, 1); }
    public static Vector4 Swizzle_001x(this Vector3 a) { return new Vector4(0, 0, 1, a.x); }
    public static Vector4 Swizzle_001y(this Vector3 a) { return new Vector4(0, 0, 1, a.y); }
    public static Vector4 Swizzle_001z(this Vector3 a) { return new Vector4(0, 0, 1, a.z); }
    public static Vector4 Swizzle_0010(this Vector3 a) { return new Vector4(0, 0, 1, 0); }
    public static Vector4 Swizzle_0011(this Vector3 a) { return new Vector4(0, 0, 1, 1); }
    public static Vector4 Swizzle_01xx(this Vector3 a) { return new Vector4(0, 1, a.x, a.x); }
    public static Vector4 Swizzle_01xy(this Vector3 a) { return new Vector4(0, 1, a.x, a.y); }
    public static Vector4 Swizzle_01xz(this Vector3 a) { return new Vector4(0, 1, a.x, a.z); }
    public static Vector4 Swizzle_01x0(this Vector3 a) { return new Vector4(0, 1, a.x, 0); }
    public static Vector4 Swizzle_01x1(this Vector3 a) { return new Vector4(0, 1, a.x, 1); }
    public static Vector4 Swizzle_01yx(this Vector3 a) { return new Vector4(0, 1, a.y, a.x); }
    public static Vector4 Swizzle_01yy(this Vector3 a) { return new Vector4(0, 1, a.y, a.y); }
    public static Vector4 Swizzle_01yz(this Vector3 a) { return new Vector4(0, 1, a.y, a.z); }
    public static Vector4 Swizzle_01y0(this Vector3 a) { return new Vector4(0, 1, a.y, 0); }
    public static Vector4 Swizzle_01y1(this Vector3 a) { return new Vector4(0, 1, a.y, 1); }
    public static Vector4 Swizzle_01zx(this Vector3 a) { return new Vector4(0, 1, a.z, a.x); }
    public static Vector4 Swizzle_01zy(this Vector3 a) { return new Vector4(0, 1, a.z, a.y); }
    public static Vector4 Swizzle_01zz(this Vector3 a) { return new Vector4(0, 1, a.z, a.z); }
    public static Vector4 Swizzle_01z0(this Vector3 a) { return new Vector4(0, 1, a.z, 0); }
    public static Vector4 Swizzle_01z1(this Vector3 a) { return new Vector4(0, 1, a.z, 1); }
    public static Vector4 Swizzle_010x(this Vector3 a) { return new Vector4(0, 1, 0, a.x); }
    public static Vector4 Swizzle_010y(this Vector3 a) { return new Vector4(0, 1, 0, a.y); }
    public static Vector4 Swizzle_010z(this Vector3 a) { return new Vector4(0, 1, 0, a.z); }
    public static Vector4 Swizzle_0100(this Vector3 a) { return new Vector4(0, 1, 0, 0); }
    public static Vector4 Swizzle_0101(this Vector3 a) { return new Vector4(0, 1, 0, 1); }
    public static Vector4 Swizzle_011x(this Vector3 a) { return new Vector4(0, 1, 1, a.x); }
    public static Vector4 Swizzle_011y(this Vector3 a) { return new Vector4(0, 1, 1, a.y); }
    public static Vector4 Swizzle_011z(this Vector3 a) { return new Vector4(0, 1, 1, a.z); }
    public static Vector4 Swizzle_0110(this Vector3 a) { return new Vector4(0, 1, 1, 0); }
    public static Vector4 Swizzle_0111(this Vector3 a) { return new Vector4(0, 1, 1, 1); }
    public static Vector4 Swizzle_1xxx(this Vector3 a) { return new Vector4(1, a.x, a.x, a.x); }
    public static Vector4 Swizzle_1xxy(this Vector3 a) { return new Vector4(1, a.x, a.x, a.y); }
    public static Vector4 Swizzle_1xxz(this Vector3 a) { return new Vector4(1, a.x, a.x, a.z); }
    public static Vector4 Swizzle_1xx0(this Vector3 a) { return new Vector4(1, a.x, a.x, 0); }
    public static Vector4 Swizzle_1xx1(this Vector3 a) { return new Vector4(1, a.x, a.x, 1); }
    public static Vector4 Swizzle_1xyx(this Vector3 a) { return new Vector4(1, a.x, a.y, a.x); }
    public static Vector4 Swizzle_1xyy(this Vector3 a) { return new Vector4(1, a.x, a.y, a.y); }
    public static Vector4 Swizzle_1xyz(this Vector3 a) { return new Vector4(1, a.x, a.y, a.z); }
    public static Vector4 Swizzle_1xy0(this Vector3 a) { return new Vector4(1, a.x, a.y, 0); }
    public static Vector4 Swizzle_1xy1(this Vector3 a) { return new Vector4(1, a.x, a.y, 1); }
    public static Vector4 Swizzle_1xzx(this Vector3 a) { return new Vector4(1, a.x, a.z, a.x); }
    public static Vector4 Swizzle_1xzy(this Vector3 a) { return new Vector4(1, a.x, a.z, a.y); }
    public static Vector4 Swizzle_1xzz(this Vector3 a) { return new Vector4(1, a.x, a.z, a.z); }
    public static Vector4 Swizzle_1xz0(this Vector3 a) { return new Vector4(1, a.x, a.z, 0); }
    public static Vector4 Swizzle_1xz1(this Vector3 a) { return new Vector4(1, a.x, a.z, 1); }
    public static Vector4 Swizzle_1x0x(this Vector3 a) { return new Vector4(1, a.x, 0, a.x); }
    public static Vector4 Swizzle_1x0y(this Vector3 a) { return new Vector4(1, a.x, 0, a.y); }
    public static Vector4 Swizzle_1x0z(this Vector3 a) { return new Vector4(1, a.x, 0, a.z); }
    public static Vector4 Swizzle_1x00(this Vector3 a) { return new Vector4(1, a.x, 0, 0); }
    public static Vector4 Swizzle_1x01(this Vector3 a) { return new Vector4(1, a.x, 0, 1); }
    public static Vector4 Swizzle_1x1x(this Vector3 a) { return new Vector4(1, a.x, 1, a.x); }
    public static Vector4 Swizzle_1x1y(this Vector3 a) { return new Vector4(1, a.x, 1, a.y); }
    public static Vector4 Swizzle_1x1z(this Vector3 a) { return new Vector4(1, a.x, 1, a.z); }
    public static Vector4 Swizzle_1x10(this Vector3 a) { return new Vector4(1, a.x, 1, 0); }
    public static Vector4 Swizzle_1x11(this Vector3 a) { return new Vector4(1, a.x, 1, 1); }
    public static Vector4 Swizzle_1yxx(this Vector3 a) { return new Vector4(1, a.y, a.x, a.x); }
    public static Vector4 Swizzle_1yxy(this Vector3 a) { return new Vector4(1, a.y, a.x, a.y); }
    public static Vector4 Swizzle_1yxz(this Vector3 a) { return new Vector4(1, a.y, a.x, a.z); }
    public static Vector4 Swizzle_1yx0(this Vector3 a) { return new Vector4(1, a.y, a.x, 0); }
    public static Vector4 Swizzle_1yx1(this Vector3 a) { return new Vector4(1, a.y, a.x, 1); }
    public static Vector4 Swizzle_1yyx(this Vector3 a) { return new Vector4(1, a.y, a.y, a.x); }
    public static Vector4 Swizzle_1yyy(this Vector3 a) { return new Vector4(1, a.y, a.y, a.y); }
    public static Vector4 Swizzle_1yyz(this Vector3 a) { return new Vector4(1, a.y, a.y, a.z); }
    public static Vector4 Swizzle_1yy0(this Vector3 a) { return new Vector4(1, a.y, a.y, 0); }
    public static Vector4 Swizzle_1yy1(this Vector3 a) { return new Vector4(1, a.y, a.y, 1); }
    public static Vector4 Swizzle_1yzx(this Vector3 a) { return new Vector4(1, a.y, a.z, a.x); }
    public static Vector4 Swizzle_1yzy(this Vector3 a) { return new Vector4(1, a.y, a.z, a.y); }
    public static Vector4 Swizzle_1yzz(this Vector3 a) { return new Vector4(1, a.y, a.z, a.z); }
    public static Vector4 Swizzle_1yz0(this Vector3 a) { return new Vector4(1, a.y, a.z, 0); }
    public static Vector4 Swizzle_1yz1(this Vector3 a) { return new Vector4(1, a.y, a.z, 1); }
    public static Vector4 Swizzle_1y0x(this Vector3 a) { return new Vector4(1, a.y, 0, a.x); }
    public static Vector4 Swizzle_1y0y(this Vector3 a) { return new Vector4(1, a.y, 0, a.y); }
    public static Vector4 Swizzle_1y0z(this Vector3 a) { return new Vector4(1, a.y, 0, a.z); }
    public static Vector4 Swizzle_1y00(this Vector3 a) { return new Vector4(1, a.y, 0, 0); }
    public static Vector4 Swizzle_1y01(this Vector3 a) { return new Vector4(1, a.y, 0, 1); }
    public static Vector4 Swizzle_1y1x(this Vector3 a) { return new Vector4(1, a.y, 1, a.x); }
    public static Vector4 Swizzle_1y1y(this Vector3 a) { return new Vector4(1, a.y, 1, a.y); }
    public static Vector4 Swizzle_1y1z(this Vector3 a) { return new Vector4(1, a.y, 1, a.z); }
    public static Vector4 Swizzle_1y10(this Vector3 a) { return new Vector4(1, a.y, 1, 0); }
    public static Vector4 Swizzle_1y11(this Vector3 a) { return new Vector4(1, a.y, 1, 1); }
    public static Vector4 Swizzle_1zxx(this Vector3 a) { return new Vector4(1, a.z, a.x, a.x); }
    public static Vector4 Swizzle_1zxy(this Vector3 a) { return new Vector4(1, a.z, a.x, a.y); }
    public static Vector4 Swizzle_1zxz(this Vector3 a) { return new Vector4(1, a.z, a.x, a.z); }
    public static Vector4 Swizzle_1zx0(this Vector3 a) { return new Vector4(1, a.z, a.x, 0); }
    public static Vector4 Swizzle_1zx1(this Vector3 a) { return new Vector4(1, a.z, a.x, 1); }
    public static Vector4 Swizzle_1zyx(this Vector3 a) { return new Vector4(1, a.z, a.y, a.x); }
    public static Vector4 Swizzle_1zyy(this Vector3 a) { return new Vector4(1, a.z, a.y, a.y); }
    public static Vector4 Swizzle_1zyz(this Vector3 a) { return new Vector4(1, a.z, a.y, a.z); }
    public static Vector4 Swizzle_1zy0(this Vector3 a) { return new Vector4(1, a.z, a.y, 0); }
    public static Vector4 Swizzle_1zy1(this Vector3 a) { return new Vector4(1, a.z, a.y, 1); }
    public static Vector4 Swizzle_1zzx(this Vector3 a) { return new Vector4(1, a.z, a.z, a.x); }
    public static Vector4 Swizzle_1zzy(this Vector3 a) { return new Vector4(1, a.z, a.z, a.y); }
    public static Vector4 Swizzle_1zzz(this Vector3 a) { return new Vector4(1, a.z, a.z, a.z); }
    public static Vector4 Swizzle_1zz0(this Vector3 a) { return new Vector4(1, a.z, a.z, 0); }
    public static Vector4 Swizzle_1zz1(this Vector3 a) { return new Vector4(1, a.z, a.z, 1); }
    public static Vector4 Swizzle_1z0x(this Vector3 a) { return new Vector4(1, a.z, 0, a.x); }
    public static Vector4 Swizzle_1z0y(this Vector3 a) { return new Vector4(1, a.z, 0, a.y); }
    public static Vector4 Swizzle_1z0z(this Vector3 a) { return new Vector4(1, a.z, 0, a.z); }
    public static Vector4 Swizzle_1z00(this Vector3 a) { return new Vector4(1, a.z, 0, 0); }
    public static Vector4 Swizzle_1z01(this Vector3 a) { return new Vector4(1, a.z, 0, 1); }
    public static Vector4 Swizzle_1z1x(this Vector3 a) { return new Vector4(1, a.z, 1, a.x); }
    public static Vector4 Swizzle_1z1y(this Vector3 a) { return new Vector4(1, a.z, 1, a.y); }
    public static Vector4 Swizzle_1z1z(this Vector3 a) { return new Vector4(1, a.z, 1, a.z); }
    public static Vector4 Swizzle_1z10(this Vector3 a) { return new Vector4(1, a.z, 1, 0); }
    public static Vector4 Swizzle_1z11(this Vector3 a) { return new Vector4(1, a.z, 1, 1); }
    public static Vector4 Swizzle_10xx(this Vector3 a) { return new Vector4(1, 0, a.x, a.x); }
    public static Vector4 Swizzle_10xy(this Vector3 a) { return new Vector4(1, 0, a.x, a.y); }
    public static Vector4 Swizzle_10xz(this Vector3 a) { return new Vector4(1, 0, a.x, a.z); }
    public static Vector4 Swizzle_10x0(this Vector3 a) { return new Vector4(1, 0, a.x, 0); }
    public static Vector4 Swizzle_10x1(this Vector3 a) { return new Vector4(1, 0, a.x, 1); }
    public static Vector4 Swizzle_10yx(this Vector3 a) { return new Vector4(1, 0, a.y, a.x); }
    public static Vector4 Swizzle_10yy(this Vector3 a) { return new Vector4(1, 0, a.y, a.y); }
    public static Vector4 Swizzle_10yz(this Vector3 a) { return new Vector4(1, 0, a.y, a.z); }
    public static Vector4 Swizzle_10y0(this Vector3 a) { return new Vector4(1, 0, a.y, 0); }
    public static Vector4 Swizzle_10y1(this Vector3 a) { return new Vector4(1, 0, a.y, 1); }
    public static Vector4 Swizzle_10zx(this Vector3 a) { return new Vector4(1, 0, a.z, a.x); }
    public static Vector4 Swizzle_10zy(this Vector3 a) { return new Vector4(1, 0, a.z, a.y); }
    public static Vector4 Swizzle_10zz(this Vector3 a) { return new Vector4(1, 0, a.z, a.z); }
    public static Vector4 Swizzle_10z0(this Vector3 a) { return new Vector4(1, 0, a.z, 0); }
    public static Vector4 Swizzle_10z1(this Vector3 a) { return new Vector4(1, 0, a.z, 1); }
    public static Vector4 Swizzle_100x(this Vector3 a) { return new Vector4(1, 0, 0, a.x); }
    public static Vector4 Swizzle_100y(this Vector3 a) { return new Vector4(1, 0, 0, a.y); }
    public static Vector4 Swizzle_100z(this Vector3 a) { return new Vector4(1, 0, 0, a.z); }
    public static Vector4 Swizzle_1000(this Vector3 a) { return new Vector4(1, 0, 0, 0); }
    public static Vector4 Swizzle_1001(this Vector3 a) { return new Vector4(1, 0, 0, 1); }
    public static Vector4 Swizzle_101x(this Vector3 a) { return new Vector4(1, 0, 1, a.x); }
    public static Vector4 Swizzle_101y(this Vector3 a) { return new Vector4(1, 0, 1, a.y); }
    public static Vector4 Swizzle_101z(this Vector3 a) { return new Vector4(1, 0, 1, a.z); }
    public static Vector4 Swizzle_1010(this Vector3 a) { return new Vector4(1, 0, 1, 0); }
    public static Vector4 Swizzle_1011(this Vector3 a) { return new Vector4(1, 0, 1, 1); }
    public static Vector4 Swizzle_11xx(this Vector3 a) { return new Vector4(1, 1, a.x, a.x); }
    public static Vector4 Swizzle_11xy(this Vector3 a) { return new Vector4(1, 1, a.x, a.y); }
    public static Vector4 Swizzle_11xz(this Vector3 a) { return new Vector4(1, 1, a.x, a.z); }
    public static Vector4 Swizzle_11x0(this Vector3 a) { return new Vector4(1, 1, a.x, 0); }
    public static Vector4 Swizzle_11x1(this Vector3 a) { return new Vector4(1, 1, a.x, 1); }
    public static Vector4 Swizzle_11yx(this Vector3 a) { return new Vector4(1, 1, a.y, a.x); }
    public static Vector4 Swizzle_11yy(this Vector3 a) { return new Vector4(1, 1, a.y, a.y); }
    public static Vector4 Swizzle_11yz(this Vector3 a) { return new Vector4(1, 1, a.y, a.z); }
    public static Vector4 Swizzle_11y0(this Vector3 a) { return new Vector4(1, 1, a.y, 0); }
    public static Vector4 Swizzle_11y1(this Vector3 a) { return new Vector4(1, 1, a.y, 1); }
    public static Vector4 Swizzle_11zx(this Vector3 a) { return new Vector4(1, 1, a.z, a.x); }
    public static Vector4 Swizzle_11zy(this Vector3 a) { return new Vector4(1, 1, a.z, a.y); }
    public static Vector4 Swizzle_11zz(this Vector3 a) { return new Vector4(1, 1, a.z, a.z); }
    public static Vector4 Swizzle_11z0(this Vector3 a) { return new Vector4(1, 1, a.z, 0); }
    public static Vector4 Swizzle_11z1(this Vector3 a) { return new Vector4(1, 1, a.z, 1); }
    public static Vector4 Swizzle_110x(this Vector3 a) { return new Vector4(1, 1, 0, a.x); }
    public static Vector4 Swizzle_110y(this Vector3 a) { return new Vector4(1, 1, 0, a.y); }
    public static Vector4 Swizzle_110z(this Vector3 a) { return new Vector4(1, 1, 0, a.z); }
    public static Vector4 Swizzle_1100(this Vector3 a) { return new Vector4(1, 1, 0, 0); }
    public static Vector4 Swizzle_1101(this Vector3 a) { return new Vector4(1, 1, 0, 1); }
    public static Vector4 Swizzle_111x(this Vector3 a) { return new Vector4(1, 1, 1, a.x); }
    public static Vector4 Swizzle_111y(this Vector3 a) { return new Vector4(1, 1, 1, a.y); }
    public static Vector4 Swizzle_111z(this Vector3 a) { return new Vector4(1, 1, 1, a.z); }
    public static Vector4 Swizzle_1110(this Vector3 a) { return new Vector4(1, 1, 1, 0); }
    public static Vector4 Swizzle_1111(this Vector3 a) { return new Vector4(1, 1, 1, 1); }
    public static Vector2 Swizzle_xx(this Vector4 a) { return new Vector2(a.x, a.x); }
    public static Vector2 Swizzle_xy(this Vector4 a) { return new Vector2(a.x, a.y); }
    public static Vector2 Swizzle_xz(this Vector4 a) { return new Vector2(a.x, a.z); }
    public static Vector2 Swizzle_xw(this Vector4 a) { return new Vector2(a.x, a.w); }
    public static Vector2 Swizzle_x0(this Vector4 a) { return new Vector2(a.x, 0); }
    public static Vector2 Swizzle_x1(this Vector4 a) { return new Vector2(a.x, 1); }
    public static Vector2 Swizzle_yx(this Vector4 a) { return new Vector2(a.y, a.x); }
    public static Vector2 Swizzle_yy(this Vector4 a) { return new Vector2(a.y, a.y); }
    public static Vector2 Swizzle_yz(this Vector4 a) { return new Vector2(a.y, a.z); }
    public static Vector2 Swizzle_yw(this Vector4 a) { return new Vector2(a.y, a.w); }
    public static Vector2 Swizzle_y0(this Vector4 a) { return new Vector2(a.y, 0); }
    public static Vector2 Swizzle_y1(this Vector4 a) { return new Vector2(a.y, 1); }
    public static Vector2 Swizzle_zx(this Vector4 a) { return new Vector2(a.z, a.x); }
    public static Vector2 Swizzle_zy(this Vector4 a) { return new Vector2(a.z, a.y); }
    public static Vector2 Swizzle_zz(this Vector4 a) { return new Vector2(a.z, a.z); }
    public static Vector2 Swizzle_zw(this Vector4 a) { return new Vector2(a.z, a.w); }
    public static Vector2 Swizzle_z0(this Vector4 a) { return new Vector2(a.z, 0); }
    public static Vector2 Swizzle_z1(this Vector4 a) { return new Vector2(a.z, 1); }
    public static Vector2 Swizzle_wx(this Vector4 a) { return new Vector2(a.w, a.x); }
    public static Vector2 Swizzle_wy(this Vector4 a) { return new Vector2(a.w, a.y); }
    public static Vector2 Swizzle_wz(this Vector4 a) { return new Vector2(a.w, a.z); }
    public static Vector2 Swizzle_ww(this Vector4 a) { return new Vector2(a.w, a.w); }
    public static Vector2 Swizzle_w0(this Vector4 a) { return new Vector2(a.w, 0); }
    public static Vector2 Swizzle_w1(this Vector4 a) { return new Vector2(a.w, 1); }
    public static Vector2 Swizzle_0x(this Vector4 a) { return new Vector2(0, a.x); }
    public static Vector2 Swizzle_0y(this Vector4 a) { return new Vector2(0, a.y); }
    public static Vector2 Swizzle_0z(this Vector4 a) { return new Vector2(0, a.z); }
    public static Vector2 Swizzle_0w(this Vector4 a) { return new Vector2(0, a.w); }
    public static Vector2 Swizzle_00(this Vector4 a) { return new Vector2(0, 0); }
    public static Vector2 Swizzle_01(this Vector4 a) { return new Vector2(0, 1); }
    public static Vector2 Swizzle_1x(this Vector4 a) { return new Vector2(1, a.x); }
    public static Vector2 Swizzle_1y(this Vector4 a) { return new Vector2(1, a.y); }
    public static Vector2 Swizzle_1z(this Vector4 a) { return new Vector2(1, a.z); }
    public static Vector2 Swizzle_1w(this Vector4 a) { return new Vector2(1, a.w); }
    public static Vector2 Swizzle_10(this Vector4 a) { return new Vector2(1, 0); }
    public static Vector2 Swizzle_11(this Vector4 a) { return new Vector2(1, 1); }
    public static Vector3 Swizzle_xxx(this Vector4 a) { return new Vector3(a.x, a.x, a.x); }
    public static Vector3 Swizzle_xxy(this Vector4 a) { return new Vector3(a.x, a.x, a.y); }
    public static Vector3 Swizzle_xxz(this Vector4 a) { return new Vector3(a.x, a.x, a.z); }
    public static Vector3 Swizzle_xxw(this Vector4 a) { return new Vector3(a.x, a.x, a.w); }
    public static Vector3 Swizzle_xx0(this Vector4 a) { return new Vector3(a.x, a.x, 0); }
    public static Vector3 Swizzle_xx1(this Vector4 a) { return new Vector3(a.x, a.x, 1); }
    public static Vector3 Swizzle_xyx(this Vector4 a) { return new Vector3(a.x, a.y, a.x); }
    public static Vector3 Swizzle_xyy(this Vector4 a) { return new Vector3(a.x, a.y, a.y); }
    public static Vector3 Swizzle_xyz(this Vector4 a) { return new Vector3(a.x, a.y, a.z); }
    public static Vector3 Swizzle_xyw(this Vector4 a) { return new Vector3(a.x, a.y, a.w); }
    public static Vector3 Swizzle_xy0(this Vector4 a) { return new Vector3(a.x, a.y, 0); }
    public static Vector3 Swizzle_xy1(this Vector4 a) { return new Vector3(a.x, a.y, 1); }
    public static Vector3 Swizzle_xzx(this Vector4 a) { return new Vector3(a.x, a.z, a.x); }
    public static Vector3 Swizzle_xzy(this Vector4 a) { return new Vector3(a.x, a.z, a.y); }
    public static Vector3 Swizzle_xzz(this Vector4 a) { return new Vector3(a.x, a.z, a.z); }
    public static Vector3 Swizzle_xzw(this Vector4 a) { return new Vector3(a.x, a.z, a.w); }
    public static Vector3 Swizzle_xz0(this Vector4 a) { return new Vector3(a.x, a.z, 0); }
    public static Vector3 Swizzle_xz1(this Vector4 a) { return new Vector3(a.x, a.z, 1); }
    public static Vector3 Swizzle_xwx(this Vector4 a) { return new Vector3(a.x, a.w, a.x); }
    public static Vector3 Swizzle_xwy(this Vector4 a) { return new Vector3(a.x, a.w, a.y); }
    public static Vector3 Swizzle_xwz(this Vector4 a) { return new Vector3(a.x, a.w, a.z); }
    public static Vector3 Swizzle_xww(this Vector4 a) { return new Vector3(a.x, a.w, a.w); }
    public static Vector3 Swizzle_xw0(this Vector4 a) { return new Vector3(a.x, a.w, 0); }
    public static Vector3 Swizzle_xw1(this Vector4 a) { return new Vector3(a.x, a.w, 1); }
    public static Vector3 Swizzle_x0x(this Vector4 a) { return new Vector3(a.x, 0, a.x); }
    public static Vector3 Swizzle_x0y(this Vector4 a) { return new Vector3(a.x, 0, a.y); }
    public static Vector3 Swizzle_x0z(this Vector4 a) { return new Vector3(a.x, 0, a.z); }
    public static Vector3 Swizzle_x0w(this Vector4 a) { return new Vector3(a.x, 0, a.w); }
    public static Vector3 Swizzle_x00(this Vector4 a) { return new Vector3(a.x, 0, 0); }
    public static Vector3 Swizzle_x01(this Vector4 a) { return new Vector3(a.x, 0, 1); }
    public static Vector3 Swizzle_x1x(this Vector4 a) { return new Vector3(a.x, 1, a.x); }
    public static Vector3 Swizzle_x1y(this Vector4 a) { return new Vector3(a.x, 1, a.y); }
    public static Vector3 Swizzle_x1z(this Vector4 a) { return new Vector3(a.x, 1, a.z); }
    public static Vector3 Swizzle_x1w(this Vector4 a) { return new Vector3(a.x, 1, a.w); }
    public static Vector3 Swizzle_x10(this Vector4 a) { return new Vector3(a.x, 1, 0); }
    public static Vector3 Swizzle_x11(this Vector4 a) { return new Vector3(a.x, 1, 1); }
    public static Vector3 Swizzle_yxx(this Vector4 a) { return new Vector3(a.y, a.x, a.x); }
    public static Vector3 Swizzle_yxy(this Vector4 a) { return new Vector3(a.y, a.x, a.y); }
    public static Vector3 Swizzle_yxz(this Vector4 a) { return new Vector3(a.y, a.x, a.z); }
    public static Vector3 Swizzle_yxw(this Vector4 a) { return new Vector3(a.y, a.x, a.w); }
    public static Vector3 Swizzle_yx0(this Vector4 a) { return new Vector3(a.y, a.x, 0); }
    public static Vector3 Swizzle_yx1(this Vector4 a) { return new Vector3(a.y, a.x, 1); }
    public static Vector3 Swizzle_yyx(this Vector4 a) { return new Vector3(a.y, a.y, a.x); }
    public static Vector3 Swizzle_yyy(this Vector4 a) { return new Vector3(a.y, a.y, a.y); }
    public static Vector3 Swizzle_yyz(this Vector4 a) { return new Vector3(a.y, a.y, a.z); }
    public static Vector3 Swizzle_yyw(this Vector4 a) { return new Vector3(a.y, a.y, a.w); }
    public static Vector3 Swizzle_yy0(this Vector4 a) { return new Vector3(a.y, a.y, 0); }
    public static Vector3 Swizzle_yy1(this Vector4 a) { return new Vector3(a.y, a.y, 1); }
    public static Vector3 Swizzle_yzx(this Vector4 a) { return new Vector3(a.y, a.z, a.x); }
    public static Vector3 Swizzle_yzy(this Vector4 a) { return new Vector3(a.y, a.z, a.y); }
    public static Vector3 Swizzle_yzz(this Vector4 a) { return new Vector3(a.y, a.z, a.z); }
    public static Vector3 Swizzle_yzw(this Vector4 a) { return new Vector3(a.y, a.z, a.w); }
    public static Vector3 Swizzle_yz0(this Vector4 a) { return new Vector3(a.y, a.z, 0); }
    public static Vector3 Swizzle_yz1(this Vector4 a) { return new Vector3(a.y, a.z, 1); }
    public static Vector3 Swizzle_ywx(this Vector4 a) { return new Vector3(a.y, a.w, a.x); }
    public static Vector3 Swizzle_ywy(this Vector4 a) { return new Vector3(a.y, a.w, a.y); }
    public static Vector3 Swizzle_ywz(this Vector4 a) { return new Vector3(a.y, a.w, a.z); }
    public static Vector3 Swizzle_yww(this Vector4 a) { return new Vector3(a.y, a.w, a.w); }
    public static Vector3 Swizzle_yw0(this Vector4 a) { return new Vector3(a.y, a.w, 0); }
    public static Vector3 Swizzle_yw1(this Vector4 a) { return new Vector3(a.y, a.w, 1); }
    public static Vector3 Swizzle_y0x(this Vector4 a) { return new Vector3(a.y, 0, a.x); }
    public static Vector3 Swizzle_y0y(this Vector4 a) { return new Vector3(a.y, 0, a.y); }
    public static Vector3 Swizzle_y0z(this Vector4 a) { return new Vector3(a.y, 0, a.z); }
    public static Vector3 Swizzle_y0w(this Vector4 a) { return new Vector3(a.y, 0, a.w); }
    public static Vector3 Swizzle_y00(this Vector4 a) { return new Vector3(a.y, 0, 0); }
    public static Vector3 Swizzle_y01(this Vector4 a) { return new Vector3(a.y, 0, 1); }
    public static Vector3 Swizzle_y1x(this Vector4 a) { return new Vector3(a.y, 1, a.x); }
    public static Vector3 Swizzle_y1y(this Vector4 a) { return new Vector3(a.y, 1, a.y); }
    public static Vector3 Swizzle_y1z(this Vector4 a) { return new Vector3(a.y, 1, a.z); }
    public static Vector3 Swizzle_y1w(this Vector4 a) { return new Vector3(a.y, 1, a.w); }
    public static Vector3 Swizzle_y10(this Vector4 a) { return new Vector3(a.y, 1, 0); }
    public static Vector3 Swizzle_y11(this Vector4 a) { return new Vector3(a.y, 1, 1); }
    public static Vector3 Swizzle_zxx(this Vector4 a) { return new Vector3(a.z, a.x, a.x); }
    public static Vector3 Swizzle_zxy(this Vector4 a) { return new Vector3(a.z, a.x, a.y); }
    public static Vector3 Swizzle_zxz(this Vector4 a) { return new Vector3(a.z, a.x, a.z); }
    public static Vector3 Swizzle_zxw(this Vector4 a) { return new Vector3(a.z, a.x, a.w); }
    public static Vector3 Swizzle_zx0(this Vector4 a) { return new Vector3(a.z, a.x, 0); }
    public static Vector3 Swizzle_zx1(this Vector4 a) { return new Vector3(a.z, a.x, 1); }
    public static Vector3 Swizzle_zyx(this Vector4 a) { return new Vector3(a.z, a.y, a.x); }
    public static Vector3 Swizzle_zyy(this Vector4 a) { return new Vector3(a.z, a.y, a.y); }
    public static Vector3 Swizzle_zyz(this Vector4 a) { return new Vector3(a.z, a.y, a.z); }
    public static Vector3 Swizzle_zyw(this Vector4 a) { return new Vector3(a.z, a.y, a.w); }
    public static Vector3 Swizzle_zy0(this Vector4 a) { return new Vector3(a.z, a.y, 0); }
    public static Vector3 Swizzle_zy1(this Vector4 a) { return new Vector3(a.z, a.y, 1); }
    public static Vector3 Swizzle_zzx(this Vector4 a) { return new Vector3(a.z, a.z, a.x); }
    public static Vector3 Swizzle_zzy(this Vector4 a) { return new Vector3(a.z, a.z, a.y); }
    public static Vector3 Swizzle_zzz(this Vector4 a) { return new Vector3(a.z, a.z, a.z); }
    public static Vector3 Swizzle_zzw(this Vector4 a) { return new Vector3(a.z, a.z, a.w); }
    public static Vector3 Swizzle_zz0(this Vector4 a) { return new Vector3(a.z, a.z, 0); }
    public static Vector3 Swizzle_zz1(this Vector4 a) { return new Vector3(a.z, a.z, 1); }
    public static Vector3 Swizzle_zwx(this Vector4 a) { return new Vector3(a.z, a.w, a.x); }
    public static Vector3 Swizzle_zwy(this Vector4 a) { return new Vector3(a.z, a.w, a.y); }
    public static Vector3 Swizzle_zwz(this Vector4 a) { return new Vector3(a.z, a.w, a.z); }
    public static Vector3 Swizzle_zww(this Vector4 a) { return new Vector3(a.z, a.w, a.w); }
    public static Vector3 Swizzle_zw0(this Vector4 a) { return new Vector3(a.z, a.w, 0); }
    public static Vector3 Swizzle_zw1(this Vector4 a) { return new Vector3(a.z, a.w, 1); }
    public static Vector3 Swizzle_z0x(this Vector4 a) { return new Vector3(a.z, 0, a.x); }
    public static Vector3 Swizzle_z0y(this Vector4 a) { return new Vector3(a.z, 0, a.y); }
    public static Vector3 Swizzle_z0z(this Vector4 a) { return new Vector3(a.z, 0, a.z); }
    public static Vector3 Swizzle_z0w(this Vector4 a) { return new Vector3(a.z, 0, a.w); }
    public static Vector3 Swizzle_z00(this Vector4 a) { return new Vector3(a.z, 0, 0); }
    public static Vector3 Swizzle_z01(this Vector4 a) { return new Vector3(a.z, 0, 1); }
    public static Vector3 Swizzle_z1x(this Vector4 a) { return new Vector3(a.z, 1, a.x); }
    public static Vector3 Swizzle_z1y(this Vector4 a) { return new Vector3(a.z, 1, a.y); }
    public static Vector3 Swizzle_z1z(this Vector4 a) { return new Vector3(a.z, 1, a.z); }
    public static Vector3 Swizzle_z1w(this Vector4 a) { return new Vector3(a.z, 1, a.w); }
    public static Vector3 Swizzle_z10(this Vector4 a) { return new Vector3(a.z, 1, 0); }
    public static Vector3 Swizzle_z11(this Vector4 a) { return new Vector3(a.z, 1, 1); }
    public static Vector3 Swizzle_wxx(this Vector4 a) { return new Vector3(a.w, a.x, a.x); }
    public static Vector3 Swizzle_wxy(this Vector4 a) { return new Vector3(a.w, a.x, a.y); }
    public static Vector3 Swizzle_wxz(this Vector4 a) { return new Vector3(a.w, a.x, a.z); }
    public static Vector3 Swizzle_wxw(this Vector4 a) { return new Vector3(a.w, a.x, a.w); }
    public static Vector3 Swizzle_wx0(this Vector4 a) { return new Vector3(a.w, a.x, 0); }
    public static Vector3 Swizzle_wx1(this Vector4 a) { return new Vector3(a.w, a.x, 1); }
    public static Vector3 Swizzle_wyx(this Vector4 a) { return new Vector3(a.w, a.y, a.x); }
    public static Vector3 Swizzle_wyy(this Vector4 a) { return new Vector3(a.w, a.y, a.y); }
    public static Vector3 Swizzle_wyz(this Vector4 a) { return new Vector3(a.w, a.y, a.z); }
    public static Vector3 Swizzle_wyw(this Vector4 a) { return new Vector3(a.w, a.y, a.w); }
    public static Vector3 Swizzle_wy0(this Vector4 a) { return new Vector3(a.w, a.y, 0); }
    public static Vector3 Swizzle_wy1(this Vector4 a) { return new Vector3(a.w, a.y, 1); }
    public static Vector3 Swizzle_wzx(this Vector4 a) { return new Vector3(a.w, a.z, a.x); }
    public static Vector3 Swizzle_wzy(this Vector4 a) { return new Vector3(a.w, a.z, a.y); }
    public static Vector3 Swizzle_wzz(this Vector4 a) { return new Vector3(a.w, a.z, a.z); }
    public static Vector3 Swizzle_wzw(this Vector4 a) { return new Vector3(a.w, a.z, a.w); }
    public static Vector3 Swizzle_wz0(this Vector4 a) { return new Vector3(a.w, a.z, 0); }
    public static Vector3 Swizzle_wz1(this Vector4 a) { return new Vector3(a.w, a.z, 1); }
    public static Vector3 Swizzle_wwx(this Vector4 a) { return new Vector3(a.w, a.w, a.x); }
    public static Vector3 Swizzle_wwy(this Vector4 a) { return new Vector3(a.w, a.w, a.y); }
    public static Vector3 Swizzle_wwz(this Vector4 a) { return new Vector3(a.w, a.w, a.z); }
    public static Vector3 Swizzle_www(this Vector4 a) { return new Vector3(a.w, a.w, a.w); }
    public static Vector3 Swizzle_ww0(this Vector4 a) { return new Vector3(a.w, a.w, 0); }
    public static Vector3 Swizzle_ww1(this Vector4 a) { return new Vector3(a.w, a.w, 1); }
    public static Vector3 Swizzle_w0x(this Vector4 a) { return new Vector3(a.w, 0, a.x); }
    public static Vector3 Swizzle_w0y(this Vector4 a) { return new Vector3(a.w, 0, a.y); }
    public static Vector3 Swizzle_w0z(this Vector4 a) { return new Vector3(a.w, 0, a.z); }
    public static Vector3 Swizzle_w0w(this Vector4 a) { return new Vector3(a.w, 0, a.w); }
    public static Vector3 Swizzle_w00(this Vector4 a) { return new Vector3(a.w, 0, 0); }
    public static Vector3 Swizzle_w01(this Vector4 a) { return new Vector3(a.w, 0, 1); }
    public static Vector3 Swizzle_w1x(this Vector4 a) { return new Vector3(a.w, 1, a.x); }
    public static Vector3 Swizzle_w1y(this Vector4 a) { return new Vector3(a.w, 1, a.y); }
    public static Vector3 Swizzle_w1z(this Vector4 a) { return new Vector3(a.w, 1, a.z); }
    public static Vector3 Swizzle_w1w(this Vector4 a) { return new Vector3(a.w, 1, a.w); }
    public static Vector3 Swizzle_w10(this Vector4 a) { return new Vector3(a.w, 1, 0); }
    public static Vector3 Swizzle_w11(this Vector4 a) { return new Vector3(a.w, 1, 1); }
    public static Vector3 Swizzle_0xx(this Vector4 a) { return new Vector3(0, a.x, a.x); }
    public static Vector3 Swizzle_0xy(this Vector4 a) { return new Vector3(0, a.x, a.y); }
    public static Vector3 Swizzle_0xz(this Vector4 a) { return new Vector3(0, a.x, a.z); }
    public static Vector3 Swizzle_0xw(this Vector4 a) { return new Vector3(0, a.x, a.w); }
    public static Vector3 Swizzle_0x0(this Vector4 a) { return new Vector3(0, a.x, 0); }
    public static Vector3 Swizzle_0x1(this Vector4 a) { return new Vector3(0, a.x, 1); }
    public static Vector3 Swizzle_0yx(this Vector4 a) { return new Vector3(0, a.y, a.x); }
    public static Vector3 Swizzle_0yy(this Vector4 a) { return new Vector3(0, a.y, a.y); }
    public static Vector3 Swizzle_0yz(this Vector4 a) { return new Vector3(0, a.y, a.z); }
    public static Vector3 Swizzle_0yw(this Vector4 a) { return new Vector3(0, a.y, a.w); }
    public static Vector3 Swizzle_0y0(this Vector4 a) { return new Vector3(0, a.y, 0); }
    public static Vector3 Swizzle_0y1(this Vector4 a) { return new Vector3(0, a.y, 1); }
    public static Vector3 Swizzle_0zx(this Vector4 a) { return new Vector3(0, a.z, a.x); }
    public static Vector3 Swizzle_0zy(this Vector4 a) { return new Vector3(0, a.z, a.y); }
    public static Vector3 Swizzle_0zz(this Vector4 a) { return new Vector3(0, a.z, a.z); }
    public static Vector3 Swizzle_0zw(this Vector4 a) { return new Vector3(0, a.z, a.w); }
    public static Vector3 Swizzle_0z0(this Vector4 a) { return new Vector3(0, a.z, 0); }
    public static Vector3 Swizzle_0z1(this Vector4 a) { return new Vector3(0, a.z, 1); }
    public static Vector3 Swizzle_0wx(this Vector4 a) { return new Vector3(0, a.w, a.x); }
    public static Vector3 Swizzle_0wy(this Vector4 a) { return new Vector3(0, a.w, a.y); }
    public static Vector3 Swizzle_0wz(this Vector4 a) { return new Vector3(0, a.w, a.z); }
    public static Vector3 Swizzle_0ww(this Vector4 a) { return new Vector3(0, a.w, a.w); }
    public static Vector3 Swizzle_0w0(this Vector4 a) { return new Vector3(0, a.w, 0); }
    public static Vector3 Swizzle_0w1(this Vector4 a) { return new Vector3(0, a.w, 1); }
    public static Vector3 Swizzle_00x(this Vector4 a) { return new Vector3(0, 0, a.x); }
    public static Vector3 Swizzle_00y(this Vector4 a) { return new Vector3(0, 0, a.y); }
    public static Vector3 Swizzle_00z(this Vector4 a) { return new Vector3(0, 0, a.z); }
    public static Vector3 Swizzle_00w(this Vector4 a) { return new Vector3(0, 0, a.w); }
    public static Vector3 Swizzle_000(this Vector4 a) { return new Vector3(0, 0, 0); }
    public static Vector3 Swizzle_001(this Vector4 a) { return new Vector3(0, 0, 1); }
    public static Vector3 Swizzle_01x(this Vector4 a) { return new Vector3(0, 1, a.x); }
    public static Vector3 Swizzle_01y(this Vector4 a) { return new Vector3(0, 1, a.y); }
    public static Vector3 Swizzle_01z(this Vector4 a) { return new Vector3(0, 1, a.z); }
    public static Vector3 Swizzle_01w(this Vector4 a) { return new Vector3(0, 1, a.w); }
    public static Vector3 Swizzle_010(this Vector4 a) { return new Vector3(0, 1, 0); }
    public static Vector3 Swizzle_011(this Vector4 a) { return new Vector3(0, 1, 1); }
    public static Vector3 Swizzle_1xx(this Vector4 a) { return new Vector3(1, a.x, a.x); }
    public static Vector3 Swizzle_1xy(this Vector4 a) { return new Vector3(1, a.x, a.y); }
    public static Vector3 Swizzle_1xz(this Vector4 a) { return new Vector3(1, a.x, a.z); }
    public static Vector3 Swizzle_1xw(this Vector4 a) { return new Vector3(1, a.x, a.w); }
    public static Vector3 Swizzle_1x0(this Vector4 a) { return new Vector3(1, a.x, 0); }
    public static Vector3 Swizzle_1x1(this Vector4 a) { return new Vector3(1, a.x, 1); }
    public static Vector3 Swizzle_1yx(this Vector4 a) { return new Vector3(1, a.y, a.x); }
    public static Vector3 Swizzle_1yy(this Vector4 a) { return new Vector3(1, a.y, a.y); }
    public static Vector3 Swizzle_1yz(this Vector4 a) { return new Vector3(1, a.y, a.z); }
    public static Vector3 Swizzle_1yw(this Vector4 a) { return new Vector3(1, a.y, a.w); }
    public static Vector3 Swizzle_1y0(this Vector4 a) { return new Vector3(1, a.y, 0); }
    public static Vector3 Swizzle_1y1(this Vector4 a) { return new Vector3(1, a.y, 1); }
    public static Vector3 Swizzle_1zx(this Vector4 a) { return new Vector3(1, a.z, a.x); }
    public static Vector3 Swizzle_1zy(this Vector4 a) { return new Vector3(1, a.z, a.y); }
    public static Vector3 Swizzle_1zz(this Vector4 a) { return new Vector3(1, a.z, a.z); }
    public static Vector3 Swizzle_1zw(this Vector4 a) { return new Vector3(1, a.z, a.w); }
    public static Vector3 Swizzle_1z0(this Vector4 a) { return new Vector3(1, a.z, 0); }
    public static Vector3 Swizzle_1z1(this Vector4 a) { return new Vector3(1, a.z, 1); }
    public static Vector3 Swizzle_1wx(this Vector4 a) { return new Vector3(1, a.w, a.x); }
    public static Vector3 Swizzle_1wy(this Vector4 a) { return new Vector3(1, a.w, a.y); }
    public static Vector3 Swizzle_1wz(this Vector4 a) { return new Vector3(1, a.w, a.z); }
    public static Vector3 Swizzle_1ww(this Vector4 a) { return new Vector3(1, a.w, a.w); }
    public static Vector3 Swizzle_1w0(this Vector4 a) { return new Vector3(1, a.w, 0); }
    public static Vector3 Swizzle_1w1(this Vector4 a) { return new Vector3(1, a.w, 1); }
    public static Vector3 Swizzle_10x(this Vector4 a) { return new Vector3(1, 0, a.x); }
    public static Vector3 Swizzle_10y(this Vector4 a) { return new Vector3(1, 0, a.y); }
    public static Vector3 Swizzle_10z(this Vector4 a) { return new Vector3(1, 0, a.z); }
    public static Vector3 Swizzle_10w(this Vector4 a) { return new Vector3(1, 0, a.w); }
    public static Vector3 Swizzle_100(this Vector4 a) { return new Vector3(1, 0, 0); }
    public static Vector3 Swizzle_101(this Vector4 a) { return new Vector3(1, 0, 1); }
    public static Vector3 Swizzle_11x(this Vector4 a) { return new Vector3(1, 1, a.x); }
    public static Vector3 Swizzle_11y(this Vector4 a) { return new Vector3(1, 1, a.y); }
    public static Vector3 Swizzle_11z(this Vector4 a) { return new Vector3(1, 1, a.z); }
    public static Vector3 Swizzle_11w(this Vector4 a) { return new Vector3(1, 1, a.w); }
    public static Vector3 Swizzle_110(this Vector4 a) { return new Vector3(1, 1, 0); }
    public static Vector3 Swizzle_111(this Vector4 a) { return new Vector3(1, 1, 1); }
    public static Vector4 Swizzle_xxxx(this Vector4 a) { return new Vector4(a.x, a.x, a.x, a.x); }
    public static Vector4 Swizzle_xxxy(this Vector4 a) { return new Vector4(a.x, a.x, a.x, a.y); }
    public static Vector4 Swizzle_xxxz(this Vector4 a) { return new Vector4(a.x, a.x, a.x, a.z); }
    public static Vector4 Swizzle_xxxw(this Vector4 a) { return new Vector4(a.x, a.x, a.x, a.w); }
    public static Vector4 Swizzle_xxx0(this Vector4 a) { return new Vector4(a.x, a.x, a.x, 0); }
    public static Vector4 Swizzle_xxx1(this Vector4 a) { return new Vector4(a.x, a.x, a.x, 1); }
    public static Vector4 Swizzle_xxyx(this Vector4 a) { return new Vector4(a.x, a.x, a.y, a.x); }
    public static Vector4 Swizzle_xxyy(this Vector4 a) { return new Vector4(a.x, a.x, a.y, a.y); }
    public static Vector4 Swizzle_xxyz(this Vector4 a) { return new Vector4(a.x, a.x, a.y, a.z); }
    public static Vector4 Swizzle_xxyw(this Vector4 a) { return new Vector4(a.x, a.x, a.y, a.w); }
    public static Vector4 Swizzle_xxy0(this Vector4 a) { return new Vector4(a.x, a.x, a.y, 0); }
    public static Vector4 Swizzle_xxy1(this Vector4 a) { return new Vector4(a.x, a.x, a.y, 1); }
    public static Vector4 Swizzle_xxzx(this Vector4 a) { return new Vector4(a.x, a.x, a.z, a.x); }
    public static Vector4 Swizzle_xxzy(this Vector4 a) { return new Vector4(a.x, a.x, a.z, a.y); }
    public static Vector4 Swizzle_xxzz(this Vector4 a) { return new Vector4(a.x, a.x, a.z, a.z); }
    public static Vector4 Swizzle_xxzw(this Vector4 a) { return new Vector4(a.x, a.x, a.z, a.w); }
    public static Vector4 Swizzle_xxz0(this Vector4 a) { return new Vector4(a.x, a.x, a.z, 0); }
    public static Vector4 Swizzle_xxz1(this Vector4 a) { return new Vector4(a.x, a.x, a.z, 1); }
    public static Vector4 Swizzle_xxwx(this Vector4 a) { return new Vector4(a.x, a.x, a.w, a.x); }
    public static Vector4 Swizzle_xxwy(this Vector4 a) { return new Vector4(a.x, a.x, a.w, a.y); }
    public static Vector4 Swizzle_xxwz(this Vector4 a) { return new Vector4(a.x, a.x, a.w, a.z); }
    public static Vector4 Swizzle_xxww(this Vector4 a) { return new Vector4(a.x, a.x, a.w, a.w); }
    public static Vector4 Swizzle_xxw0(this Vector4 a) { return new Vector4(a.x, a.x, a.w, 0); }
    public static Vector4 Swizzle_xxw1(this Vector4 a) { return new Vector4(a.x, a.x, a.w, 1); }
    public static Vector4 Swizzle_xx0x(this Vector4 a) { return new Vector4(a.x, a.x, 0, a.x); }
    public static Vector4 Swizzle_xx0y(this Vector4 a) { return new Vector4(a.x, a.x, 0, a.y); }
    public static Vector4 Swizzle_xx0z(this Vector4 a) { return new Vector4(a.x, a.x, 0, a.z); }
    public static Vector4 Swizzle_xx0w(this Vector4 a) { return new Vector4(a.x, a.x, 0, a.w); }
    public static Vector4 Swizzle_xx00(this Vector4 a) { return new Vector4(a.x, a.x, 0, 0); }
    public static Vector4 Swizzle_xx01(this Vector4 a) { return new Vector4(a.x, a.x, 0, 1); }
    public static Vector4 Swizzle_xx1x(this Vector4 a) { return new Vector4(a.x, a.x, 1, a.x); }
    public static Vector4 Swizzle_xx1y(this Vector4 a) { return new Vector4(a.x, a.x, 1, a.y); }
    public static Vector4 Swizzle_xx1z(this Vector4 a) { return new Vector4(a.x, a.x, 1, a.z); }
    public static Vector4 Swizzle_xx1w(this Vector4 a) { return new Vector4(a.x, a.x, 1, a.w); }
    public static Vector4 Swizzle_xx10(this Vector4 a) { return new Vector4(a.x, a.x, 1, 0); }
    public static Vector4 Swizzle_xx11(this Vector4 a) { return new Vector4(a.x, a.x, 1, 1); }
    public static Vector4 Swizzle_xyxx(this Vector4 a) { return new Vector4(a.x, a.y, a.x, a.x); }
    public static Vector4 Swizzle_xyxy(this Vector4 a) { return new Vector4(a.x, a.y, a.x, a.y); }
    public static Vector4 Swizzle_xyxz(this Vector4 a) { return new Vector4(a.x, a.y, a.x, a.z); }
    public static Vector4 Swizzle_xyxw(this Vector4 a) { return new Vector4(a.x, a.y, a.x, a.w); }
    public static Vector4 Swizzle_xyx0(this Vector4 a) { return new Vector4(a.x, a.y, a.x, 0); }
    public static Vector4 Swizzle_xyx1(this Vector4 a) { return new Vector4(a.x, a.y, a.x, 1); }
    public static Vector4 Swizzle_xyyx(this Vector4 a) { return new Vector4(a.x, a.y, a.y, a.x); }
    public static Vector4 Swizzle_xyyy(this Vector4 a) { return new Vector4(a.x, a.y, a.y, a.y); }
    public static Vector4 Swizzle_xyyz(this Vector4 a) { return new Vector4(a.x, a.y, a.y, a.z); }
    public static Vector4 Swizzle_xyyw(this Vector4 a) { return new Vector4(a.x, a.y, a.y, a.w); }
    public static Vector4 Swizzle_xyy0(this Vector4 a) { return new Vector4(a.x, a.y, a.y, 0); }
    public static Vector4 Swizzle_xyy1(this Vector4 a) { return new Vector4(a.x, a.y, a.y, 1); }
    public static Vector4 Swizzle_xyzx(this Vector4 a) { return new Vector4(a.x, a.y, a.z, a.x); }
    public static Vector4 Swizzle_xyzy(this Vector4 a) { return new Vector4(a.x, a.y, a.z, a.y); }
    public static Vector4 Swizzle_xyzz(this Vector4 a) { return new Vector4(a.x, a.y, a.z, a.z); }
    public static Vector4 Swizzle_xyzw(this Vector4 a) { return new Vector4(a.x, a.y, a.z, a.w); }
    public static Vector4 Swizzle_xyz0(this Vector4 a) { return new Vector4(a.x, a.y, a.z, 0); }
    public static Vector4 Swizzle_xyz1(this Vector4 a) { return new Vector4(a.x, a.y, a.z, 1); }
    public static Vector4 Swizzle_xywx(this Vector4 a) { return new Vector4(a.x, a.y, a.w, a.x); }
    public static Vector4 Swizzle_xywy(this Vector4 a) { return new Vector4(a.x, a.y, a.w, a.y); }
    public static Vector4 Swizzle_xywz(this Vector4 a) { return new Vector4(a.x, a.y, a.w, a.z); }
    public static Vector4 Swizzle_xyww(this Vector4 a) { return new Vector4(a.x, a.y, a.w, a.w); }
    public static Vector4 Swizzle_xyw0(this Vector4 a) { return new Vector4(a.x, a.y, a.w, 0); }
    public static Vector4 Swizzle_xyw1(this Vector4 a) { return new Vector4(a.x, a.y, a.w, 1); }
    public static Vector4 Swizzle_xy0x(this Vector4 a) { return new Vector4(a.x, a.y, 0, a.x); }
    public static Vector4 Swizzle_xy0y(this Vector4 a) { return new Vector4(a.x, a.y, 0, a.y); }
    public static Vector4 Swizzle_xy0z(this Vector4 a) { return new Vector4(a.x, a.y, 0, a.z); }
    public static Vector4 Swizzle_xy0w(this Vector4 a) { return new Vector4(a.x, a.y, 0, a.w); }
    public static Vector4 Swizzle_xy00(this Vector4 a) { return new Vector4(a.x, a.y, 0, 0); }
    public static Vector4 Swizzle_xy01(this Vector4 a) { return new Vector4(a.x, a.y, 0, 1); }
    public static Vector4 Swizzle_xy1x(this Vector4 a) { return new Vector4(a.x, a.y, 1, a.x); }
    public static Vector4 Swizzle_xy1y(this Vector4 a) { return new Vector4(a.x, a.y, 1, a.y); }
    public static Vector4 Swizzle_xy1z(this Vector4 a) { return new Vector4(a.x, a.y, 1, a.z); }
    public static Vector4 Swizzle_xy1w(this Vector4 a) { return new Vector4(a.x, a.y, 1, a.w); }
    public static Vector4 Swizzle_xy10(this Vector4 a) { return new Vector4(a.x, a.y, 1, 0); }
    public static Vector4 Swizzle_xy11(this Vector4 a) { return new Vector4(a.x, a.y, 1, 1); }
    public static Vector4 Swizzle_xzxx(this Vector4 a) { return new Vector4(a.x, a.z, a.x, a.x); }
    public static Vector4 Swizzle_xzxy(this Vector4 a) { return new Vector4(a.x, a.z, a.x, a.y); }
    public static Vector4 Swizzle_xzxz(this Vector4 a) { return new Vector4(a.x, a.z, a.x, a.z); }
    public static Vector4 Swizzle_xzxw(this Vector4 a) { return new Vector4(a.x, a.z, a.x, a.w); }
    public static Vector4 Swizzle_xzx0(this Vector4 a) { return new Vector4(a.x, a.z, a.x, 0); }
    public static Vector4 Swizzle_xzx1(this Vector4 a) { return new Vector4(a.x, a.z, a.x, 1); }
    public static Vector4 Swizzle_xzyx(this Vector4 a) { return new Vector4(a.x, a.z, a.y, a.x); }
    public static Vector4 Swizzle_xzyy(this Vector4 a) { return new Vector4(a.x, a.z, a.y, a.y); }
    public static Vector4 Swizzle_xzyz(this Vector4 a) { return new Vector4(a.x, a.z, a.y, a.z); }
    public static Vector4 Swizzle_xzyw(this Vector4 a) { return new Vector4(a.x, a.z, a.y, a.w); }
    public static Vector4 Swizzle_xzy0(this Vector4 a) { return new Vector4(a.x, a.z, a.y, 0); }
    public static Vector4 Swizzle_xzy1(this Vector4 a) { return new Vector4(a.x, a.z, a.y, 1); }
    public static Vector4 Swizzle_xzzx(this Vector4 a) { return new Vector4(a.x, a.z, a.z, a.x); }
    public static Vector4 Swizzle_xzzy(this Vector4 a) { return new Vector4(a.x, a.z, a.z, a.y); }
    public static Vector4 Swizzle_xzzz(this Vector4 a) { return new Vector4(a.x, a.z, a.z, a.z); }
    public static Vector4 Swizzle_xzzw(this Vector4 a) { return new Vector4(a.x, a.z, a.z, a.w); }
    public static Vector4 Swizzle_xzz0(this Vector4 a) { return new Vector4(a.x, a.z, a.z, 0); }
    public static Vector4 Swizzle_xzz1(this Vector4 a) { return new Vector4(a.x, a.z, a.z, 1); }
    public static Vector4 Swizzle_xzwx(this Vector4 a) { return new Vector4(a.x, a.z, a.w, a.x); }
    public static Vector4 Swizzle_xzwy(this Vector4 a) { return new Vector4(a.x, a.z, a.w, a.y); }
    public static Vector4 Swizzle_xzwz(this Vector4 a) { return new Vector4(a.x, a.z, a.w, a.z); }
    public static Vector4 Swizzle_xzww(this Vector4 a) { return new Vector4(a.x, a.z, a.w, a.w); }
    public static Vector4 Swizzle_xzw0(this Vector4 a) { return new Vector4(a.x, a.z, a.w, 0); }
    public static Vector4 Swizzle_xzw1(this Vector4 a) { return new Vector4(a.x, a.z, a.w, 1); }
    public static Vector4 Swizzle_xz0x(this Vector4 a) { return new Vector4(a.x, a.z, 0, a.x); }
    public static Vector4 Swizzle_xz0y(this Vector4 a) { return new Vector4(a.x, a.z, 0, a.y); }
    public static Vector4 Swizzle_xz0z(this Vector4 a) { return new Vector4(a.x, a.z, 0, a.z); }
    public static Vector4 Swizzle_xz0w(this Vector4 a) { return new Vector4(a.x, a.z, 0, a.w); }
    public static Vector4 Swizzle_xz00(this Vector4 a) { return new Vector4(a.x, a.z, 0, 0); }
    public static Vector4 Swizzle_xz01(this Vector4 a) { return new Vector4(a.x, a.z, 0, 1); }
    public static Vector4 Swizzle_xz1x(this Vector4 a) { return new Vector4(a.x, a.z, 1, a.x); }
    public static Vector4 Swizzle_xz1y(this Vector4 a) { return new Vector4(a.x, a.z, 1, a.y); }
    public static Vector4 Swizzle_xz1z(this Vector4 a) { return new Vector4(a.x, a.z, 1, a.z); }
    public static Vector4 Swizzle_xz1w(this Vector4 a) { return new Vector4(a.x, a.z, 1, a.w); }
    public static Vector4 Swizzle_xz10(this Vector4 a) { return new Vector4(a.x, a.z, 1, 0); }
    public static Vector4 Swizzle_xz11(this Vector4 a) { return new Vector4(a.x, a.z, 1, 1); }
    public static Vector4 Swizzle_xwxx(this Vector4 a) { return new Vector4(a.x, a.w, a.x, a.x); }
    public static Vector4 Swizzle_xwxy(this Vector4 a) { return new Vector4(a.x, a.w, a.x, a.y); }
    public static Vector4 Swizzle_xwxz(this Vector4 a) { return new Vector4(a.x, a.w, a.x, a.z); }
    public static Vector4 Swizzle_xwxw(this Vector4 a) { return new Vector4(a.x, a.w, a.x, a.w); }
    public static Vector4 Swizzle_xwx0(this Vector4 a) { return new Vector4(a.x, a.w, a.x, 0); }
    public static Vector4 Swizzle_xwx1(this Vector4 a) { return new Vector4(a.x, a.w, a.x, 1); }
    public static Vector4 Swizzle_xwyx(this Vector4 a) { return new Vector4(a.x, a.w, a.y, a.x); }
    public static Vector4 Swizzle_xwyy(this Vector4 a) { return new Vector4(a.x, a.w, a.y, a.y); }
    public static Vector4 Swizzle_xwyz(this Vector4 a) { return new Vector4(a.x, a.w, a.y, a.z); }
    public static Vector4 Swizzle_xwyw(this Vector4 a) { return new Vector4(a.x, a.w, a.y, a.w); }
    public static Vector4 Swizzle_xwy0(this Vector4 a) { return new Vector4(a.x, a.w, a.y, 0); }
    public static Vector4 Swizzle_xwy1(this Vector4 a) { return new Vector4(a.x, a.w, a.y, 1); }
    public static Vector4 Swizzle_xwzx(this Vector4 a) { return new Vector4(a.x, a.w, a.z, a.x); }
    public static Vector4 Swizzle_xwzy(this Vector4 a) { return new Vector4(a.x, a.w, a.z, a.y); }
    public static Vector4 Swizzle_xwzz(this Vector4 a) { return new Vector4(a.x, a.w, a.z, a.z); }
    public static Vector4 Swizzle_xwzw(this Vector4 a) { return new Vector4(a.x, a.w, a.z, a.w); }
    public static Vector4 Swizzle_xwz0(this Vector4 a) { return new Vector4(a.x, a.w, a.z, 0); }
    public static Vector4 Swizzle_xwz1(this Vector4 a) { return new Vector4(a.x, a.w, a.z, 1); }
    public static Vector4 Swizzle_xwwx(this Vector4 a) { return new Vector4(a.x, a.w, a.w, a.x); }
    public static Vector4 Swizzle_xwwy(this Vector4 a) { return new Vector4(a.x, a.w, a.w, a.y); }
    public static Vector4 Swizzle_xwwz(this Vector4 a) { return new Vector4(a.x, a.w, a.w, a.z); }
    public static Vector4 Swizzle_xwww(this Vector4 a) { return new Vector4(a.x, a.w, a.w, a.w); }
    public static Vector4 Swizzle_xww0(this Vector4 a) { return new Vector4(a.x, a.w, a.w, 0); }
    public static Vector4 Swizzle_xww1(this Vector4 a) { return new Vector4(a.x, a.w, a.w, 1); }
    public static Vector4 Swizzle_xw0x(this Vector4 a) { return new Vector4(a.x, a.w, 0, a.x); }
    public static Vector4 Swizzle_xw0y(this Vector4 a) { return new Vector4(a.x, a.w, 0, a.y); }
    public static Vector4 Swizzle_xw0z(this Vector4 a) { return new Vector4(a.x, a.w, 0, a.z); }
    public static Vector4 Swizzle_xw0w(this Vector4 a) { return new Vector4(a.x, a.w, 0, a.w); }
    public static Vector4 Swizzle_xw00(this Vector4 a) { return new Vector4(a.x, a.w, 0, 0); }
    public static Vector4 Swizzle_xw01(this Vector4 a) { return new Vector4(a.x, a.w, 0, 1); }
    public static Vector4 Swizzle_xw1x(this Vector4 a) { return new Vector4(a.x, a.w, 1, a.x); }
    public static Vector4 Swizzle_xw1y(this Vector4 a) { return new Vector4(a.x, a.w, 1, a.y); }
    public static Vector4 Swizzle_xw1z(this Vector4 a) { return new Vector4(a.x, a.w, 1, a.z); }
    public static Vector4 Swizzle_xw1w(this Vector4 a) { return new Vector4(a.x, a.w, 1, a.w); }
    public static Vector4 Swizzle_xw10(this Vector4 a) { return new Vector4(a.x, a.w, 1, 0); }
    public static Vector4 Swizzle_xw11(this Vector4 a) { return new Vector4(a.x, a.w, 1, 1); }
    public static Vector4 Swizzle_x0xx(this Vector4 a) { return new Vector4(a.x, 0, a.x, a.x); }
    public static Vector4 Swizzle_x0xy(this Vector4 a) { return new Vector4(a.x, 0, a.x, a.y); }
    public static Vector4 Swizzle_x0xz(this Vector4 a) { return new Vector4(a.x, 0, a.x, a.z); }
    public static Vector4 Swizzle_x0xw(this Vector4 a) { return new Vector4(a.x, 0, a.x, a.w); }
    public static Vector4 Swizzle_x0x0(this Vector4 a) { return new Vector4(a.x, 0, a.x, 0); }
    public static Vector4 Swizzle_x0x1(this Vector4 a) { return new Vector4(a.x, 0, a.x, 1); }
    public static Vector4 Swizzle_x0yx(this Vector4 a) { return new Vector4(a.x, 0, a.y, a.x); }
    public static Vector4 Swizzle_x0yy(this Vector4 a) { return new Vector4(a.x, 0, a.y, a.y); }
    public static Vector4 Swizzle_x0yz(this Vector4 a) { return new Vector4(a.x, 0, a.y, a.z); }
    public static Vector4 Swizzle_x0yw(this Vector4 a) { return new Vector4(a.x, 0, a.y, a.w); }
    public static Vector4 Swizzle_x0y0(this Vector4 a) { return new Vector4(a.x, 0, a.y, 0); }
    public static Vector4 Swizzle_x0y1(this Vector4 a) { return new Vector4(a.x, 0, a.y, 1); }
    public static Vector4 Swizzle_x0zx(this Vector4 a) { return new Vector4(a.x, 0, a.z, a.x); }
    public static Vector4 Swizzle_x0zy(this Vector4 a) { return new Vector4(a.x, 0, a.z, a.y); }
    public static Vector4 Swizzle_x0zz(this Vector4 a) { return new Vector4(a.x, 0, a.z, a.z); }
    public static Vector4 Swizzle_x0zw(this Vector4 a) { return new Vector4(a.x, 0, a.z, a.w); }
    public static Vector4 Swizzle_x0z0(this Vector4 a) { return new Vector4(a.x, 0, a.z, 0); }
    public static Vector4 Swizzle_x0z1(this Vector4 a) { return new Vector4(a.x, 0, a.z, 1); }
    public static Vector4 Swizzle_x0wx(this Vector4 a) { return new Vector4(a.x, 0, a.w, a.x); }
    public static Vector4 Swizzle_x0wy(this Vector4 a) { return new Vector4(a.x, 0, a.w, a.y); }
    public static Vector4 Swizzle_x0wz(this Vector4 a) { return new Vector4(a.x, 0, a.w, a.z); }
    public static Vector4 Swizzle_x0ww(this Vector4 a) { return new Vector4(a.x, 0, a.w, a.w); }
    public static Vector4 Swizzle_x0w0(this Vector4 a) { return new Vector4(a.x, 0, a.w, 0); }
    public static Vector4 Swizzle_x0w1(this Vector4 a) { return new Vector4(a.x, 0, a.w, 1); }
    public static Vector4 Swizzle_x00x(this Vector4 a) { return new Vector4(a.x, 0, 0, a.x); }
    public static Vector4 Swizzle_x00y(this Vector4 a) { return new Vector4(a.x, 0, 0, a.y); }
    public static Vector4 Swizzle_x00z(this Vector4 a) { return new Vector4(a.x, 0, 0, a.z); }
    public static Vector4 Swizzle_x00w(this Vector4 a) { return new Vector4(a.x, 0, 0, a.w); }
    public static Vector4 Swizzle_x000(this Vector4 a) { return new Vector4(a.x, 0, 0, 0); }
    public static Vector4 Swizzle_x001(this Vector4 a) { return new Vector4(a.x, 0, 0, 1); }
    public static Vector4 Swizzle_x01x(this Vector4 a) { return new Vector4(a.x, 0, 1, a.x); }
    public static Vector4 Swizzle_x01y(this Vector4 a) { return new Vector4(a.x, 0, 1, a.y); }
    public static Vector4 Swizzle_x01z(this Vector4 a) { return new Vector4(a.x, 0, 1, a.z); }
    public static Vector4 Swizzle_x01w(this Vector4 a) { return new Vector4(a.x, 0, 1, a.w); }
    public static Vector4 Swizzle_x010(this Vector4 a) { return new Vector4(a.x, 0, 1, 0); }
    public static Vector4 Swizzle_x011(this Vector4 a) { return new Vector4(a.x, 0, 1, 1); }
    public static Vector4 Swizzle_x1xx(this Vector4 a) { return new Vector4(a.x, 1, a.x, a.x); }
    public static Vector4 Swizzle_x1xy(this Vector4 a) { return new Vector4(a.x, 1, a.x, a.y); }
    public static Vector4 Swizzle_x1xz(this Vector4 a) { return new Vector4(a.x, 1, a.x, a.z); }
    public static Vector4 Swizzle_x1xw(this Vector4 a) { return new Vector4(a.x, 1, a.x, a.w); }
    public static Vector4 Swizzle_x1x0(this Vector4 a) { return new Vector4(a.x, 1, a.x, 0); }
    public static Vector4 Swizzle_x1x1(this Vector4 a) { return new Vector4(a.x, 1, a.x, 1); }
    public static Vector4 Swizzle_x1yx(this Vector4 a) { return new Vector4(a.x, 1, a.y, a.x); }
    public static Vector4 Swizzle_x1yy(this Vector4 a) { return new Vector4(a.x, 1, a.y, a.y); }
    public static Vector4 Swizzle_x1yz(this Vector4 a) { return new Vector4(a.x, 1, a.y, a.z); }
    public static Vector4 Swizzle_x1yw(this Vector4 a) { return new Vector4(a.x, 1, a.y, a.w); }
    public static Vector4 Swizzle_x1y0(this Vector4 a) { return new Vector4(a.x, 1, a.y, 0); }
    public static Vector4 Swizzle_x1y1(this Vector4 a) { return new Vector4(a.x, 1, a.y, 1); }
    public static Vector4 Swizzle_x1zx(this Vector4 a) { return new Vector4(a.x, 1, a.z, a.x); }
    public static Vector4 Swizzle_x1zy(this Vector4 a) { return new Vector4(a.x, 1, a.z, a.y); }
    public static Vector4 Swizzle_x1zz(this Vector4 a) { return new Vector4(a.x, 1, a.z, a.z); }
    public static Vector4 Swizzle_x1zw(this Vector4 a) { return new Vector4(a.x, 1, a.z, a.w); }
    public static Vector4 Swizzle_x1z0(this Vector4 a) { return new Vector4(a.x, 1, a.z, 0); }
    public static Vector4 Swizzle_x1z1(this Vector4 a) { return new Vector4(a.x, 1, a.z, 1); }
    public static Vector4 Swizzle_x1wx(this Vector4 a) { return new Vector4(a.x, 1, a.w, a.x); }
    public static Vector4 Swizzle_x1wy(this Vector4 a) { return new Vector4(a.x, 1, a.w, a.y); }
    public static Vector4 Swizzle_x1wz(this Vector4 a) { return new Vector4(a.x, 1, a.w, a.z); }
    public static Vector4 Swizzle_x1ww(this Vector4 a) { return new Vector4(a.x, 1, a.w, a.w); }
    public static Vector4 Swizzle_x1w0(this Vector4 a) { return new Vector4(a.x, 1, a.w, 0); }
    public static Vector4 Swizzle_x1w1(this Vector4 a) { return new Vector4(a.x, 1, a.w, 1); }
    public static Vector4 Swizzle_x10x(this Vector4 a) { return new Vector4(a.x, 1, 0, a.x); }
    public static Vector4 Swizzle_x10y(this Vector4 a) { return new Vector4(a.x, 1, 0, a.y); }
    public static Vector4 Swizzle_x10z(this Vector4 a) { return new Vector4(a.x, 1, 0, a.z); }
    public static Vector4 Swizzle_x10w(this Vector4 a) { return new Vector4(a.x, 1, 0, a.w); }
    public static Vector4 Swizzle_x100(this Vector4 a) { return new Vector4(a.x, 1, 0, 0); }
    public static Vector4 Swizzle_x101(this Vector4 a) { return new Vector4(a.x, 1, 0, 1); }
    public static Vector4 Swizzle_x11x(this Vector4 a) { return new Vector4(a.x, 1, 1, a.x); }
    public static Vector4 Swizzle_x11y(this Vector4 a) { return new Vector4(a.x, 1, 1, a.y); }
    public static Vector4 Swizzle_x11z(this Vector4 a) { return new Vector4(a.x, 1, 1, a.z); }
    public static Vector4 Swizzle_x11w(this Vector4 a) { return new Vector4(a.x, 1, 1, a.w); }
    public static Vector4 Swizzle_x110(this Vector4 a) { return new Vector4(a.x, 1, 1, 0); }
    public static Vector4 Swizzle_x111(this Vector4 a) { return new Vector4(a.x, 1, 1, 1); }
    public static Vector4 Swizzle_yxxx(this Vector4 a) { return new Vector4(a.y, a.x, a.x, a.x); }
    public static Vector4 Swizzle_yxxy(this Vector4 a) { return new Vector4(a.y, a.x, a.x, a.y); }
    public static Vector4 Swizzle_yxxz(this Vector4 a) { return new Vector4(a.y, a.x, a.x, a.z); }
    public static Vector4 Swizzle_yxxw(this Vector4 a) { return new Vector4(a.y, a.x, a.x, a.w); }
    public static Vector4 Swizzle_yxx0(this Vector4 a) { return new Vector4(a.y, a.x, a.x, 0); }
    public static Vector4 Swizzle_yxx1(this Vector4 a) { return new Vector4(a.y, a.x, a.x, 1); }
    public static Vector4 Swizzle_yxyx(this Vector4 a) { return new Vector4(a.y, a.x, a.y, a.x); }
    public static Vector4 Swizzle_yxyy(this Vector4 a) { return new Vector4(a.y, a.x, a.y, a.y); }
    public static Vector4 Swizzle_yxyz(this Vector4 a) { return new Vector4(a.y, a.x, a.y, a.z); }
    public static Vector4 Swizzle_yxyw(this Vector4 a) { return new Vector4(a.y, a.x, a.y, a.w); }
    public static Vector4 Swizzle_yxy0(this Vector4 a) { return new Vector4(a.y, a.x, a.y, 0); }
    public static Vector4 Swizzle_yxy1(this Vector4 a) { return new Vector4(a.y, a.x, a.y, 1); }
    public static Vector4 Swizzle_yxzx(this Vector4 a) { return new Vector4(a.y, a.x, a.z, a.x); }
    public static Vector4 Swizzle_yxzy(this Vector4 a) { return new Vector4(a.y, a.x, a.z, a.y); }
    public static Vector4 Swizzle_yxzz(this Vector4 a) { return new Vector4(a.y, a.x, a.z, a.z); }
    public static Vector4 Swizzle_yxzw(this Vector4 a) { return new Vector4(a.y, a.x, a.z, a.w); }
    public static Vector4 Swizzle_yxz0(this Vector4 a) { return new Vector4(a.y, a.x, a.z, 0); }
    public static Vector4 Swizzle_yxz1(this Vector4 a) { return new Vector4(a.y, a.x, a.z, 1); }
    public static Vector4 Swizzle_yxwx(this Vector4 a) { return new Vector4(a.y, a.x, a.w, a.x); }
    public static Vector4 Swizzle_yxwy(this Vector4 a) { return new Vector4(a.y, a.x, a.w, a.y); }
    public static Vector4 Swizzle_yxwz(this Vector4 a) { return new Vector4(a.y, a.x, a.w, a.z); }
    public static Vector4 Swizzle_yxww(this Vector4 a) { return new Vector4(a.y, a.x, a.w, a.w); }
    public static Vector4 Swizzle_yxw0(this Vector4 a) { return new Vector4(a.y, a.x, a.w, 0); }
    public static Vector4 Swizzle_yxw1(this Vector4 a) { return new Vector4(a.y, a.x, a.w, 1); }
    public static Vector4 Swizzle_yx0x(this Vector4 a) { return new Vector4(a.y, a.x, 0, a.x); }
    public static Vector4 Swizzle_yx0y(this Vector4 a) { return new Vector4(a.y, a.x, 0, a.y); }
    public static Vector4 Swizzle_yx0z(this Vector4 a) { return new Vector4(a.y, a.x, 0, a.z); }
    public static Vector4 Swizzle_yx0w(this Vector4 a) { return new Vector4(a.y, a.x, 0, a.w); }
    public static Vector4 Swizzle_yx00(this Vector4 a) { return new Vector4(a.y, a.x, 0, 0); }
    public static Vector4 Swizzle_yx01(this Vector4 a) { return new Vector4(a.y, a.x, 0, 1); }
    public static Vector4 Swizzle_yx1x(this Vector4 a) { return new Vector4(a.y, a.x, 1, a.x); }
    public static Vector4 Swizzle_yx1y(this Vector4 a) { return new Vector4(a.y, a.x, 1, a.y); }
    public static Vector4 Swizzle_yx1z(this Vector4 a) { return new Vector4(a.y, a.x, 1, a.z); }
    public static Vector4 Swizzle_yx1w(this Vector4 a) { return new Vector4(a.y, a.x, 1, a.w); }
    public static Vector4 Swizzle_yx10(this Vector4 a) { return new Vector4(a.y, a.x, 1, 0); }
    public static Vector4 Swizzle_yx11(this Vector4 a) { return new Vector4(a.y, a.x, 1, 1); }
    public static Vector4 Swizzle_yyxx(this Vector4 a) { return new Vector4(a.y, a.y, a.x, a.x); }
    public static Vector4 Swizzle_yyxy(this Vector4 a) { return new Vector4(a.y, a.y, a.x, a.y); }
    public static Vector4 Swizzle_yyxz(this Vector4 a) { return new Vector4(a.y, a.y, a.x, a.z); }
    public static Vector4 Swizzle_yyxw(this Vector4 a) { return new Vector4(a.y, a.y, a.x, a.w); }
    public static Vector4 Swizzle_yyx0(this Vector4 a) { return new Vector4(a.y, a.y, a.x, 0); }
    public static Vector4 Swizzle_yyx1(this Vector4 a) { return new Vector4(a.y, a.y, a.x, 1); }
    public static Vector4 Swizzle_yyyx(this Vector4 a) { return new Vector4(a.y, a.y, a.y, a.x); }
    public static Vector4 Swizzle_yyyy(this Vector4 a) { return new Vector4(a.y, a.y, a.y, a.y); }
    public static Vector4 Swizzle_yyyz(this Vector4 a) { return new Vector4(a.y, a.y, a.y, a.z); }
    public static Vector4 Swizzle_yyyw(this Vector4 a) { return new Vector4(a.y, a.y, a.y, a.w); }
    public static Vector4 Swizzle_yyy0(this Vector4 a) { return new Vector4(a.y, a.y, a.y, 0); }
    public static Vector4 Swizzle_yyy1(this Vector4 a) { return new Vector4(a.y, a.y, a.y, 1); }
    public static Vector4 Swizzle_yyzx(this Vector4 a) { return new Vector4(a.y, a.y, a.z, a.x); }
    public static Vector4 Swizzle_yyzy(this Vector4 a) { return new Vector4(a.y, a.y, a.z, a.y); }
    public static Vector4 Swizzle_yyzz(this Vector4 a) { return new Vector4(a.y, a.y, a.z, a.z); }
    public static Vector4 Swizzle_yyzw(this Vector4 a) { return new Vector4(a.y, a.y, a.z, a.w); }
    public static Vector4 Swizzle_yyz0(this Vector4 a) { return new Vector4(a.y, a.y, a.z, 0); }
    public static Vector4 Swizzle_yyz1(this Vector4 a) { return new Vector4(a.y, a.y, a.z, 1); }
    public static Vector4 Swizzle_yywx(this Vector4 a) { return new Vector4(a.y, a.y, a.w, a.x); }
    public static Vector4 Swizzle_yywy(this Vector4 a) { return new Vector4(a.y, a.y, a.w, a.y); }
    public static Vector4 Swizzle_yywz(this Vector4 a) { return new Vector4(a.y, a.y, a.w, a.z); }
    public static Vector4 Swizzle_yyww(this Vector4 a) { return new Vector4(a.y, a.y, a.w, a.w); }
    public static Vector4 Swizzle_yyw0(this Vector4 a) { return new Vector4(a.y, a.y, a.w, 0); }
    public static Vector4 Swizzle_yyw1(this Vector4 a) { return new Vector4(a.y, a.y, a.w, 1); }
    public static Vector4 Swizzle_yy0x(this Vector4 a) { return new Vector4(a.y, a.y, 0, a.x); }
    public static Vector4 Swizzle_yy0y(this Vector4 a) { return new Vector4(a.y, a.y, 0, a.y); }
    public static Vector4 Swizzle_yy0z(this Vector4 a) { return new Vector4(a.y, a.y, 0, a.z); }
    public static Vector4 Swizzle_yy0w(this Vector4 a) { return new Vector4(a.y, a.y, 0, a.w); }
    public static Vector4 Swizzle_yy00(this Vector4 a) { return new Vector4(a.y, a.y, 0, 0); }
    public static Vector4 Swizzle_yy01(this Vector4 a) { return new Vector4(a.y, a.y, 0, 1); }
    public static Vector4 Swizzle_yy1x(this Vector4 a) { return new Vector4(a.y, a.y, 1, a.x); }
    public static Vector4 Swizzle_yy1y(this Vector4 a) { return new Vector4(a.y, a.y, 1, a.y); }
    public static Vector4 Swizzle_yy1z(this Vector4 a) { return new Vector4(a.y, a.y, 1, a.z); }
    public static Vector4 Swizzle_yy1w(this Vector4 a) { return new Vector4(a.y, a.y, 1, a.w); }
    public static Vector4 Swizzle_yy10(this Vector4 a) { return new Vector4(a.y, a.y, 1, 0); }
    public static Vector4 Swizzle_yy11(this Vector4 a) { return new Vector4(a.y, a.y, 1, 1); }
    public static Vector4 Swizzle_yzxx(this Vector4 a) { return new Vector4(a.y, a.z, a.x, a.x); }
    public static Vector4 Swizzle_yzxy(this Vector4 a) { return new Vector4(a.y, a.z, a.x, a.y); }
    public static Vector4 Swizzle_yzxz(this Vector4 a) { return new Vector4(a.y, a.z, a.x, a.z); }
    public static Vector4 Swizzle_yzxw(this Vector4 a) { return new Vector4(a.y, a.z, a.x, a.w); }
    public static Vector4 Swizzle_yzx0(this Vector4 a) { return new Vector4(a.y, a.z, a.x, 0); }
    public static Vector4 Swizzle_yzx1(this Vector4 a) { return new Vector4(a.y, a.z, a.x, 1); }
    public static Vector4 Swizzle_yzyx(this Vector4 a) { return new Vector4(a.y, a.z, a.y, a.x); }
    public static Vector4 Swizzle_yzyy(this Vector4 a) { return new Vector4(a.y, a.z, a.y, a.y); }
    public static Vector4 Swizzle_yzyz(this Vector4 a) { return new Vector4(a.y, a.z, a.y, a.z); }
    public static Vector4 Swizzle_yzyw(this Vector4 a) { return new Vector4(a.y, a.z, a.y, a.w); }
    public static Vector4 Swizzle_yzy0(this Vector4 a) { return new Vector4(a.y, a.z, a.y, 0); }
    public static Vector4 Swizzle_yzy1(this Vector4 a) { return new Vector4(a.y, a.z, a.y, 1); }
    public static Vector4 Swizzle_yzzx(this Vector4 a) { return new Vector4(a.y, a.z, a.z, a.x); }
    public static Vector4 Swizzle_yzzy(this Vector4 a) { return new Vector4(a.y, a.z, a.z, a.y); }
    public static Vector4 Swizzle_yzzz(this Vector4 a) { return new Vector4(a.y, a.z, a.z, a.z); }
    public static Vector4 Swizzle_yzzw(this Vector4 a) { return new Vector4(a.y, a.z, a.z, a.w); }
    public static Vector4 Swizzle_yzz0(this Vector4 a) { return new Vector4(a.y, a.z, a.z, 0); }
    public static Vector4 Swizzle_yzz1(this Vector4 a) { return new Vector4(a.y, a.z, a.z, 1); }
    public static Vector4 Swizzle_yzwx(this Vector4 a) { return new Vector4(a.y, a.z, a.w, a.x); }
    public static Vector4 Swizzle_yzwy(this Vector4 a) { return new Vector4(a.y, a.z, a.w, a.y); }
    public static Vector4 Swizzle_yzwz(this Vector4 a) { return new Vector4(a.y, a.z, a.w, a.z); }
    public static Vector4 Swizzle_yzww(this Vector4 a) { return new Vector4(a.y, a.z, a.w, a.w); }
    public static Vector4 Swizzle_yzw0(this Vector4 a) { return new Vector4(a.y, a.z, a.w, 0); }
    public static Vector4 Swizzle_yzw1(this Vector4 a) { return new Vector4(a.y, a.z, a.w, 1); }
    public static Vector4 Swizzle_yz0x(this Vector4 a) { return new Vector4(a.y, a.z, 0, a.x); }
    public static Vector4 Swizzle_yz0y(this Vector4 a) { return new Vector4(a.y, a.z, 0, a.y); }
    public static Vector4 Swizzle_yz0z(this Vector4 a) { return new Vector4(a.y, a.z, 0, a.z); }
    public static Vector4 Swizzle_yz0w(this Vector4 a) { return new Vector4(a.y, a.z, 0, a.w); }
    public static Vector4 Swizzle_yz00(this Vector4 a) { return new Vector4(a.y, a.z, 0, 0); }
    public static Vector4 Swizzle_yz01(this Vector4 a) { return new Vector4(a.y, a.z, 0, 1); }
    public static Vector4 Swizzle_yz1x(this Vector4 a) { return new Vector4(a.y, a.z, 1, a.x); }
    public static Vector4 Swizzle_yz1y(this Vector4 a) { return new Vector4(a.y, a.z, 1, a.y); }
    public static Vector4 Swizzle_yz1z(this Vector4 a) { return new Vector4(a.y, a.z, 1, a.z); }
    public static Vector4 Swizzle_yz1w(this Vector4 a) { return new Vector4(a.y, a.z, 1, a.w); }
    public static Vector4 Swizzle_yz10(this Vector4 a) { return new Vector4(a.y, a.z, 1, 0); }
    public static Vector4 Swizzle_yz11(this Vector4 a) { return new Vector4(a.y, a.z, 1, 1); }
    public static Vector4 Swizzle_ywxx(this Vector4 a) { return new Vector4(a.y, a.w, a.x, a.x); }
    public static Vector4 Swizzle_ywxy(this Vector4 a) { return new Vector4(a.y, a.w, a.x, a.y); }
    public static Vector4 Swizzle_ywxz(this Vector4 a) { return new Vector4(a.y, a.w, a.x, a.z); }
    public static Vector4 Swizzle_ywxw(this Vector4 a) { return new Vector4(a.y, a.w, a.x, a.w); }
    public static Vector4 Swizzle_ywx0(this Vector4 a) { return new Vector4(a.y, a.w, a.x, 0); }
    public static Vector4 Swizzle_ywx1(this Vector4 a) { return new Vector4(a.y, a.w, a.x, 1); }
    public static Vector4 Swizzle_ywyx(this Vector4 a) { return new Vector4(a.y, a.w, a.y, a.x); }
    public static Vector4 Swizzle_ywyy(this Vector4 a) { return new Vector4(a.y, a.w, a.y, a.y); }
    public static Vector4 Swizzle_ywyz(this Vector4 a) { return new Vector4(a.y, a.w, a.y, a.z); }
    public static Vector4 Swizzle_ywyw(this Vector4 a) { return new Vector4(a.y, a.w, a.y, a.w); }
    public static Vector4 Swizzle_ywy0(this Vector4 a) { return new Vector4(a.y, a.w, a.y, 0); }
    public static Vector4 Swizzle_ywy1(this Vector4 a) { return new Vector4(a.y, a.w, a.y, 1); }
    public static Vector4 Swizzle_ywzx(this Vector4 a) { return new Vector4(a.y, a.w, a.z, a.x); }
    public static Vector4 Swizzle_ywzy(this Vector4 a) { return new Vector4(a.y, a.w, a.z, a.y); }
    public static Vector4 Swizzle_ywzz(this Vector4 a) { return new Vector4(a.y, a.w, a.z, a.z); }
    public static Vector4 Swizzle_ywzw(this Vector4 a) { return new Vector4(a.y, a.w, a.z, a.w); }
    public static Vector4 Swizzle_ywz0(this Vector4 a) { return new Vector4(a.y, a.w, a.z, 0); }
    public static Vector4 Swizzle_ywz1(this Vector4 a) { return new Vector4(a.y, a.w, a.z, 1); }
    public static Vector4 Swizzle_ywwx(this Vector4 a) { return new Vector4(a.y, a.w, a.w, a.x); }
    public static Vector4 Swizzle_ywwy(this Vector4 a) { return new Vector4(a.y, a.w, a.w, a.y); }
    public static Vector4 Swizzle_ywwz(this Vector4 a) { return new Vector4(a.y, a.w, a.w, a.z); }
    public static Vector4 Swizzle_ywww(this Vector4 a) { return new Vector4(a.y, a.w, a.w, a.w); }
    public static Vector4 Swizzle_yww0(this Vector4 a) { return new Vector4(a.y, a.w, a.w, 0); }
    public static Vector4 Swizzle_yww1(this Vector4 a) { return new Vector4(a.y, a.w, a.w, 1); }
    public static Vector4 Swizzle_yw0x(this Vector4 a) { return new Vector4(a.y, a.w, 0, a.x); }
    public static Vector4 Swizzle_yw0y(this Vector4 a) { return new Vector4(a.y, a.w, 0, a.y); }
    public static Vector4 Swizzle_yw0z(this Vector4 a) { return new Vector4(a.y, a.w, 0, a.z); }
    public static Vector4 Swizzle_yw0w(this Vector4 a) { return new Vector4(a.y, a.w, 0, a.w); }
    public static Vector4 Swizzle_yw00(this Vector4 a) { return new Vector4(a.y, a.w, 0, 0); }
    public static Vector4 Swizzle_yw01(this Vector4 a) { return new Vector4(a.y, a.w, 0, 1); }
    public static Vector4 Swizzle_yw1x(this Vector4 a) { return new Vector4(a.y, a.w, 1, a.x); }
    public static Vector4 Swizzle_yw1y(this Vector4 a) { return new Vector4(a.y, a.w, 1, a.y); }
    public static Vector4 Swizzle_yw1z(this Vector4 a) { return new Vector4(a.y, a.w, 1, a.z); }
    public static Vector4 Swizzle_yw1w(this Vector4 a) { return new Vector4(a.y, a.w, 1, a.w); }
    public static Vector4 Swizzle_yw10(this Vector4 a) { return new Vector4(a.y, a.w, 1, 0); }
    public static Vector4 Swizzle_yw11(this Vector4 a) { return new Vector4(a.y, a.w, 1, 1); }
    public static Vector4 Swizzle_y0xx(this Vector4 a) { return new Vector4(a.y, 0, a.x, a.x); }
    public static Vector4 Swizzle_y0xy(this Vector4 a) { return new Vector4(a.y, 0, a.x, a.y); }
    public static Vector4 Swizzle_y0xz(this Vector4 a) { return new Vector4(a.y, 0, a.x, a.z); }
    public static Vector4 Swizzle_y0xw(this Vector4 a) { return new Vector4(a.y, 0, a.x, a.w); }
    public static Vector4 Swizzle_y0x0(this Vector4 a) { return new Vector4(a.y, 0, a.x, 0); }
    public static Vector4 Swizzle_y0x1(this Vector4 a) { return new Vector4(a.y, 0, a.x, 1); }
    public static Vector4 Swizzle_y0yx(this Vector4 a) { return new Vector4(a.y, 0, a.y, a.x); }
    public static Vector4 Swizzle_y0yy(this Vector4 a) { return new Vector4(a.y, 0, a.y, a.y); }
    public static Vector4 Swizzle_y0yz(this Vector4 a) { return new Vector4(a.y, 0, a.y, a.z); }
    public static Vector4 Swizzle_y0yw(this Vector4 a) { return new Vector4(a.y, 0, a.y, a.w); }
    public static Vector4 Swizzle_y0y0(this Vector4 a) { return new Vector4(a.y, 0, a.y, 0); }
    public static Vector4 Swizzle_y0y1(this Vector4 a) { return new Vector4(a.y, 0, a.y, 1); }
    public static Vector4 Swizzle_y0zx(this Vector4 a) { return new Vector4(a.y, 0, a.z, a.x); }
    public static Vector4 Swizzle_y0zy(this Vector4 a) { return new Vector4(a.y, 0, a.z, a.y); }
    public static Vector4 Swizzle_y0zz(this Vector4 a) { return new Vector4(a.y, 0, a.z, a.z); }
    public static Vector4 Swizzle_y0zw(this Vector4 a) { return new Vector4(a.y, 0, a.z, a.w); }
    public static Vector4 Swizzle_y0z0(this Vector4 a) { return new Vector4(a.y, 0, a.z, 0); }
    public static Vector4 Swizzle_y0z1(this Vector4 a) { return new Vector4(a.y, 0, a.z, 1); }
    public static Vector4 Swizzle_y0wx(this Vector4 a) { return new Vector4(a.y, 0, a.w, a.x); }
    public static Vector4 Swizzle_y0wy(this Vector4 a) { return new Vector4(a.y, 0, a.w, a.y); }
    public static Vector4 Swizzle_y0wz(this Vector4 a) { return new Vector4(a.y, 0, a.w, a.z); }
    public static Vector4 Swizzle_y0ww(this Vector4 a) { return new Vector4(a.y, 0, a.w, a.w); }
    public static Vector4 Swizzle_y0w0(this Vector4 a) { return new Vector4(a.y, 0, a.w, 0); }
    public static Vector4 Swizzle_y0w1(this Vector4 a) { return new Vector4(a.y, 0, a.w, 1); }
    public static Vector4 Swizzle_y00x(this Vector4 a) { return new Vector4(a.y, 0, 0, a.x); }
    public static Vector4 Swizzle_y00y(this Vector4 a) { return new Vector4(a.y, 0, 0, a.y); }
    public static Vector4 Swizzle_y00z(this Vector4 a) { return new Vector4(a.y, 0, 0, a.z); }
    public static Vector4 Swizzle_y00w(this Vector4 a) { return new Vector4(a.y, 0, 0, a.w); }
    public static Vector4 Swizzle_y000(this Vector4 a) { return new Vector4(a.y, 0, 0, 0); }
    public static Vector4 Swizzle_y001(this Vector4 a) { return new Vector4(a.y, 0, 0, 1); }
    public static Vector4 Swizzle_y01x(this Vector4 a) { return new Vector4(a.y, 0, 1, a.x); }
    public static Vector4 Swizzle_y01y(this Vector4 a) { return new Vector4(a.y, 0, 1, a.y); }
    public static Vector4 Swizzle_y01z(this Vector4 a) { return new Vector4(a.y, 0, 1, a.z); }
    public static Vector4 Swizzle_y01w(this Vector4 a) { return new Vector4(a.y, 0, 1, a.w); }
    public static Vector4 Swizzle_y010(this Vector4 a) { return new Vector4(a.y, 0, 1, 0); }
    public static Vector4 Swizzle_y011(this Vector4 a) { return new Vector4(a.y, 0, 1, 1); }
    public static Vector4 Swizzle_y1xx(this Vector4 a) { return new Vector4(a.y, 1, a.x, a.x); }
    public static Vector4 Swizzle_y1xy(this Vector4 a) { return new Vector4(a.y, 1, a.x, a.y); }
    public static Vector4 Swizzle_y1xz(this Vector4 a) { return new Vector4(a.y, 1, a.x, a.z); }
    public static Vector4 Swizzle_y1xw(this Vector4 a) { return new Vector4(a.y, 1, a.x, a.w); }
    public static Vector4 Swizzle_y1x0(this Vector4 a) { return new Vector4(a.y, 1, a.x, 0); }
    public static Vector4 Swizzle_y1x1(this Vector4 a) { return new Vector4(a.y, 1, a.x, 1); }
    public static Vector4 Swizzle_y1yx(this Vector4 a) { return new Vector4(a.y, 1, a.y, a.x); }
    public static Vector4 Swizzle_y1yy(this Vector4 a) { return new Vector4(a.y, 1, a.y, a.y); }
    public static Vector4 Swizzle_y1yz(this Vector4 a) { return new Vector4(a.y, 1, a.y, a.z); }
    public static Vector4 Swizzle_y1yw(this Vector4 a) { return new Vector4(a.y, 1, a.y, a.w); }
    public static Vector4 Swizzle_y1y0(this Vector4 a) { return new Vector4(a.y, 1, a.y, 0); }
    public static Vector4 Swizzle_y1y1(this Vector4 a) { return new Vector4(a.y, 1, a.y, 1); }
    public static Vector4 Swizzle_y1zx(this Vector4 a) { return new Vector4(a.y, 1, a.z, a.x); }
    public static Vector4 Swizzle_y1zy(this Vector4 a) { return new Vector4(a.y, 1, a.z, a.y); }
    public static Vector4 Swizzle_y1zz(this Vector4 a) { return new Vector4(a.y, 1, a.z, a.z); }
    public static Vector4 Swizzle_y1zw(this Vector4 a) { return new Vector4(a.y, 1, a.z, a.w); }
    public static Vector4 Swizzle_y1z0(this Vector4 a) { return new Vector4(a.y, 1, a.z, 0); }
    public static Vector4 Swizzle_y1z1(this Vector4 a) { return new Vector4(a.y, 1, a.z, 1); }
    public static Vector4 Swizzle_y1wx(this Vector4 a) { return new Vector4(a.y, 1, a.w, a.x); }
    public static Vector4 Swizzle_y1wy(this Vector4 a) { return new Vector4(a.y, 1, a.w, a.y); }
    public static Vector4 Swizzle_y1wz(this Vector4 a) { return new Vector4(a.y, 1, a.w, a.z); }
    public static Vector4 Swizzle_y1ww(this Vector4 a) { return new Vector4(a.y, 1, a.w, a.w); }
    public static Vector4 Swizzle_y1w0(this Vector4 a) { return new Vector4(a.y, 1, a.w, 0); }
    public static Vector4 Swizzle_y1w1(this Vector4 a) { return new Vector4(a.y, 1, a.w, 1); }
    public static Vector4 Swizzle_y10x(this Vector4 a) { return new Vector4(a.y, 1, 0, a.x); }
    public static Vector4 Swizzle_y10y(this Vector4 a) { return new Vector4(a.y, 1, 0, a.y); }
    public static Vector4 Swizzle_y10z(this Vector4 a) { return new Vector4(a.y, 1, 0, a.z); }
    public static Vector4 Swizzle_y10w(this Vector4 a) { return new Vector4(a.y, 1, 0, a.w); }
    public static Vector4 Swizzle_y100(this Vector4 a) { return new Vector4(a.y, 1, 0, 0); }
    public static Vector4 Swizzle_y101(this Vector4 a) { return new Vector4(a.y, 1, 0, 1); }
    public static Vector4 Swizzle_y11x(this Vector4 a) { return new Vector4(a.y, 1, 1, a.x); }
    public static Vector4 Swizzle_y11y(this Vector4 a) { return new Vector4(a.y, 1, 1, a.y); }
    public static Vector4 Swizzle_y11z(this Vector4 a) { return new Vector4(a.y, 1, 1, a.z); }
    public static Vector4 Swizzle_y11w(this Vector4 a) { return new Vector4(a.y, 1, 1, a.w); }
    public static Vector4 Swizzle_y110(this Vector4 a) { return new Vector4(a.y, 1, 1, 0); }
    public static Vector4 Swizzle_y111(this Vector4 a) { return new Vector4(a.y, 1, 1, 1); }
    public static Vector4 Swizzle_zxxx(this Vector4 a) { return new Vector4(a.z, a.x, a.x, a.x); }
    public static Vector4 Swizzle_zxxy(this Vector4 a) { return new Vector4(a.z, a.x, a.x, a.y); }
    public static Vector4 Swizzle_zxxz(this Vector4 a) { return new Vector4(a.z, a.x, a.x, a.z); }
    public static Vector4 Swizzle_zxxw(this Vector4 a) { return new Vector4(a.z, a.x, a.x, a.w); }
    public static Vector4 Swizzle_zxx0(this Vector4 a) { return new Vector4(a.z, a.x, a.x, 0); }
    public static Vector4 Swizzle_zxx1(this Vector4 a) { return new Vector4(a.z, a.x, a.x, 1); }
    public static Vector4 Swizzle_zxyx(this Vector4 a) { return new Vector4(a.z, a.x, a.y, a.x); }
    public static Vector4 Swizzle_zxyy(this Vector4 a) { return new Vector4(a.z, a.x, a.y, a.y); }
    public static Vector4 Swizzle_zxyz(this Vector4 a) { return new Vector4(a.z, a.x, a.y, a.z); }
    public static Vector4 Swizzle_zxyw(this Vector4 a) { return new Vector4(a.z, a.x, a.y, a.w); }
    public static Vector4 Swizzle_zxy0(this Vector4 a) { return new Vector4(a.z, a.x, a.y, 0); }
    public static Vector4 Swizzle_zxy1(this Vector4 a) { return new Vector4(a.z, a.x, a.y, 1); }
    public static Vector4 Swizzle_zxzx(this Vector4 a) { return new Vector4(a.z, a.x, a.z, a.x); }
    public static Vector4 Swizzle_zxzy(this Vector4 a) { return new Vector4(a.z, a.x, a.z, a.y); }
    public static Vector4 Swizzle_zxzz(this Vector4 a) { return new Vector4(a.z, a.x, a.z, a.z); }
    public static Vector4 Swizzle_zxzw(this Vector4 a) { return new Vector4(a.z, a.x, a.z, a.w); }
    public static Vector4 Swizzle_zxz0(this Vector4 a) { return new Vector4(a.z, a.x, a.z, 0); }
    public static Vector4 Swizzle_zxz1(this Vector4 a) { return new Vector4(a.z, a.x, a.z, 1); }
    public static Vector4 Swizzle_zxwx(this Vector4 a) { return new Vector4(a.z, a.x, a.w, a.x); }
    public static Vector4 Swizzle_zxwy(this Vector4 a) { return new Vector4(a.z, a.x, a.w, a.y); }
    public static Vector4 Swizzle_zxwz(this Vector4 a) { return new Vector4(a.z, a.x, a.w, a.z); }
    public static Vector4 Swizzle_zxww(this Vector4 a) { return new Vector4(a.z, a.x, a.w, a.w); }
    public static Vector4 Swizzle_zxw0(this Vector4 a) { return new Vector4(a.z, a.x, a.w, 0); }
    public static Vector4 Swizzle_zxw1(this Vector4 a) { return new Vector4(a.z, a.x, a.w, 1); }
    public static Vector4 Swizzle_zx0x(this Vector4 a) { return new Vector4(a.z, a.x, 0, a.x); }
    public static Vector4 Swizzle_zx0y(this Vector4 a) { return new Vector4(a.z, a.x, 0, a.y); }
    public static Vector4 Swizzle_zx0z(this Vector4 a) { return new Vector4(a.z, a.x, 0, a.z); }
    public static Vector4 Swizzle_zx0w(this Vector4 a) { return new Vector4(a.z, a.x, 0, a.w); }
    public static Vector4 Swizzle_zx00(this Vector4 a) { return new Vector4(a.z, a.x, 0, 0); }
    public static Vector4 Swizzle_zx01(this Vector4 a) { return new Vector4(a.z, a.x, 0, 1); }
    public static Vector4 Swizzle_zx1x(this Vector4 a) { return new Vector4(a.z, a.x, 1, a.x); }
    public static Vector4 Swizzle_zx1y(this Vector4 a) { return new Vector4(a.z, a.x, 1, a.y); }
    public static Vector4 Swizzle_zx1z(this Vector4 a) { return new Vector4(a.z, a.x, 1, a.z); }
    public static Vector4 Swizzle_zx1w(this Vector4 a) { return new Vector4(a.z, a.x, 1, a.w); }
    public static Vector4 Swizzle_zx10(this Vector4 a) { return new Vector4(a.z, a.x, 1, 0); }
    public static Vector4 Swizzle_zx11(this Vector4 a) { return new Vector4(a.z, a.x, 1, 1); }
    public static Vector4 Swizzle_zyxx(this Vector4 a) { return new Vector4(a.z, a.y, a.x, a.x); }
    public static Vector4 Swizzle_zyxy(this Vector4 a) { return new Vector4(a.z, a.y, a.x, a.y); }
    public static Vector4 Swizzle_zyxz(this Vector4 a) { return new Vector4(a.z, a.y, a.x, a.z); }
    public static Vector4 Swizzle_zyxw(this Vector4 a) { return new Vector4(a.z, a.y, a.x, a.w); }
    public static Vector4 Swizzle_zyx0(this Vector4 a) { return new Vector4(a.z, a.y, a.x, 0); }
    public static Vector4 Swizzle_zyx1(this Vector4 a) { return new Vector4(a.z, a.y, a.x, 1); }
    public static Vector4 Swizzle_zyyx(this Vector4 a) { return new Vector4(a.z, a.y, a.y, a.x); }
    public static Vector4 Swizzle_zyyy(this Vector4 a) { return new Vector4(a.z, a.y, a.y, a.y); }
    public static Vector4 Swizzle_zyyz(this Vector4 a) { return new Vector4(a.z, a.y, a.y, a.z); }
    public static Vector4 Swizzle_zyyw(this Vector4 a) { return new Vector4(a.z, a.y, a.y, a.w); }
    public static Vector4 Swizzle_zyy0(this Vector4 a) { return new Vector4(a.z, a.y, a.y, 0); }
    public static Vector4 Swizzle_zyy1(this Vector4 a) { return new Vector4(a.z, a.y, a.y, 1); }
    public static Vector4 Swizzle_zyzx(this Vector4 a) { return new Vector4(a.z, a.y, a.z, a.x); }
    public static Vector4 Swizzle_zyzy(this Vector4 a) { return new Vector4(a.z, a.y, a.z, a.y); }
    public static Vector4 Swizzle_zyzz(this Vector4 a) { return new Vector4(a.z, a.y, a.z, a.z); }
    public static Vector4 Swizzle_zyzw(this Vector4 a) { return new Vector4(a.z, a.y, a.z, a.w); }
    public static Vector4 Swizzle_zyz0(this Vector4 a) { return new Vector4(a.z, a.y, a.z, 0); }
    public static Vector4 Swizzle_zyz1(this Vector4 a) { return new Vector4(a.z, a.y, a.z, 1); }
    public static Vector4 Swizzle_zywx(this Vector4 a) { return new Vector4(a.z, a.y, a.w, a.x); }
    public static Vector4 Swizzle_zywy(this Vector4 a) { return new Vector4(a.z, a.y, a.w, a.y); }
    public static Vector4 Swizzle_zywz(this Vector4 a) { return new Vector4(a.z, a.y, a.w, a.z); }
    public static Vector4 Swizzle_zyww(this Vector4 a) { return new Vector4(a.z, a.y, a.w, a.w); }
    public static Vector4 Swizzle_zyw0(this Vector4 a) { return new Vector4(a.z, a.y, a.w, 0); }
    public static Vector4 Swizzle_zyw1(this Vector4 a) { return new Vector4(a.z, a.y, a.w, 1); }
    public static Vector4 Swizzle_zy0x(this Vector4 a) { return new Vector4(a.z, a.y, 0, a.x); }
    public static Vector4 Swizzle_zy0y(this Vector4 a) { return new Vector4(a.z, a.y, 0, a.y); }
    public static Vector4 Swizzle_zy0z(this Vector4 a) { return new Vector4(a.z, a.y, 0, a.z); }
    public static Vector4 Swizzle_zy0w(this Vector4 a) { return new Vector4(a.z, a.y, 0, a.w); }
    public static Vector4 Swizzle_zy00(this Vector4 a) { return new Vector4(a.z, a.y, 0, 0); }
    public static Vector4 Swizzle_zy01(this Vector4 a) { return new Vector4(a.z, a.y, 0, 1); }
    public static Vector4 Swizzle_zy1x(this Vector4 a) { return new Vector4(a.z, a.y, 1, a.x); }
    public static Vector4 Swizzle_zy1y(this Vector4 a) { return new Vector4(a.z, a.y, 1, a.y); }
    public static Vector4 Swizzle_zy1z(this Vector4 a) { return new Vector4(a.z, a.y, 1, a.z); }
    public static Vector4 Swizzle_zy1w(this Vector4 a) { return new Vector4(a.z, a.y, 1, a.w); }
    public static Vector4 Swizzle_zy10(this Vector4 a) { return new Vector4(a.z, a.y, 1, 0); }
    public static Vector4 Swizzle_zy11(this Vector4 a) { return new Vector4(a.z, a.y, 1, 1); }
    public static Vector4 Swizzle_zzxx(this Vector4 a) { return new Vector4(a.z, a.z, a.x, a.x); }
    public static Vector4 Swizzle_zzxy(this Vector4 a) { return new Vector4(a.z, a.z, a.x, a.y); }
    public static Vector4 Swizzle_zzxz(this Vector4 a) { return new Vector4(a.z, a.z, a.x, a.z); }
    public static Vector4 Swizzle_zzxw(this Vector4 a) { return new Vector4(a.z, a.z, a.x, a.w); }
    public static Vector4 Swizzle_zzx0(this Vector4 a) { return new Vector4(a.z, a.z, a.x, 0); }
    public static Vector4 Swizzle_zzx1(this Vector4 a) { return new Vector4(a.z, a.z, a.x, 1); }
    public static Vector4 Swizzle_zzyx(this Vector4 a) { return new Vector4(a.z, a.z, a.y, a.x); }
    public static Vector4 Swizzle_zzyy(this Vector4 a) { return new Vector4(a.z, a.z, a.y, a.y); }
    public static Vector4 Swizzle_zzyz(this Vector4 a) { return new Vector4(a.z, a.z, a.y, a.z); }
    public static Vector4 Swizzle_zzyw(this Vector4 a) { return new Vector4(a.z, a.z, a.y, a.w); }
    public static Vector4 Swizzle_zzy0(this Vector4 a) { return new Vector4(a.z, a.z, a.y, 0); }
    public static Vector4 Swizzle_zzy1(this Vector4 a) { return new Vector4(a.z, a.z, a.y, 1); }
    public static Vector4 Swizzle_zzzx(this Vector4 a) { return new Vector4(a.z, a.z, a.z, a.x); }
    public static Vector4 Swizzle_zzzy(this Vector4 a) { return new Vector4(a.z, a.z, a.z, a.y); }
    public static Vector4 Swizzle_zzzz(this Vector4 a) { return new Vector4(a.z, a.z, a.z, a.z); }
    public static Vector4 Swizzle_zzzw(this Vector4 a) { return new Vector4(a.z, a.z, a.z, a.w); }
    public static Vector4 Swizzle_zzz0(this Vector4 a) { return new Vector4(a.z, a.z, a.z, 0); }
    public static Vector4 Swizzle_zzz1(this Vector4 a) { return new Vector4(a.z, a.z, a.z, 1); }
    public static Vector4 Swizzle_zzwx(this Vector4 a) { return new Vector4(a.z, a.z, a.w, a.x); }
    public static Vector4 Swizzle_zzwy(this Vector4 a) { return new Vector4(a.z, a.z, a.w, a.y); }
    public static Vector4 Swizzle_zzwz(this Vector4 a) { return new Vector4(a.z, a.z, a.w, a.z); }
    public static Vector4 Swizzle_zzww(this Vector4 a) { return new Vector4(a.z, a.z, a.w, a.w); }
    public static Vector4 Swizzle_zzw0(this Vector4 a) { return new Vector4(a.z, a.z, a.w, 0); }
    public static Vector4 Swizzle_zzw1(this Vector4 a) { return new Vector4(a.z, a.z, a.w, 1); }
    public static Vector4 Swizzle_zz0x(this Vector4 a) { return new Vector4(a.z, a.z, 0, a.x); }
    public static Vector4 Swizzle_zz0y(this Vector4 a) { return new Vector4(a.z, a.z, 0, a.y); }
    public static Vector4 Swizzle_zz0z(this Vector4 a) { return new Vector4(a.z, a.z, 0, a.z); }
    public static Vector4 Swizzle_zz0w(this Vector4 a) { return new Vector4(a.z, a.z, 0, a.w); }
    public static Vector4 Swizzle_zz00(this Vector4 a) { return new Vector4(a.z, a.z, 0, 0); }
    public static Vector4 Swizzle_zz01(this Vector4 a) { return new Vector4(a.z, a.z, 0, 1); }
    public static Vector4 Swizzle_zz1x(this Vector4 a) { return new Vector4(a.z, a.z, 1, a.x); }
    public static Vector4 Swizzle_zz1y(this Vector4 a) { return new Vector4(a.z, a.z, 1, a.y); }
    public static Vector4 Swizzle_zz1z(this Vector4 a) { return new Vector4(a.z, a.z, 1, a.z); }
    public static Vector4 Swizzle_zz1w(this Vector4 a) { return new Vector4(a.z, a.z, 1, a.w); }
    public static Vector4 Swizzle_zz10(this Vector4 a) { return new Vector4(a.z, a.z, 1, 0); }
    public static Vector4 Swizzle_zz11(this Vector4 a) { return new Vector4(a.z, a.z, 1, 1); }
    public static Vector4 Swizzle_zwxx(this Vector4 a) { return new Vector4(a.z, a.w, a.x, a.x); }
    public static Vector4 Swizzle_zwxy(this Vector4 a) { return new Vector4(a.z, a.w, a.x, a.y); }
    public static Vector4 Swizzle_zwxz(this Vector4 a) { return new Vector4(a.z, a.w, a.x, a.z); }
    public static Vector4 Swizzle_zwxw(this Vector4 a) { return new Vector4(a.z, a.w, a.x, a.w); }
    public static Vector4 Swizzle_zwx0(this Vector4 a) { return new Vector4(a.z, a.w, a.x, 0); }
    public static Vector4 Swizzle_zwx1(this Vector4 a) { return new Vector4(a.z, a.w, a.x, 1); }
    public static Vector4 Swizzle_zwyx(this Vector4 a) { return new Vector4(a.z, a.w, a.y, a.x); }
    public static Vector4 Swizzle_zwyy(this Vector4 a) { return new Vector4(a.z, a.w, a.y, a.y); }
    public static Vector4 Swizzle_zwyz(this Vector4 a) { return new Vector4(a.z, a.w, a.y, a.z); }
    public static Vector4 Swizzle_zwyw(this Vector4 a) { return new Vector4(a.z, a.w, a.y, a.w); }
    public static Vector4 Swizzle_zwy0(this Vector4 a) { return new Vector4(a.z, a.w, a.y, 0); }
    public static Vector4 Swizzle_zwy1(this Vector4 a) { return new Vector4(a.z, a.w, a.y, 1); }
    public static Vector4 Swizzle_zwzx(this Vector4 a) { return new Vector4(a.z, a.w, a.z, a.x); }
    public static Vector4 Swizzle_zwzy(this Vector4 a) { return new Vector4(a.z, a.w, a.z, a.y); }
    public static Vector4 Swizzle_zwzz(this Vector4 a) { return new Vector4(a.z, a.w, a.z, a.z); }
    public static Vector4 Swizzle_zwzw(this Vector4 a) { return new Vector4(a.z, a.w, a.z, a.w); }
    public static Vector4 Swizzle_zwz0(this Vector4 a) { return new Vector4(a.z, a.w, a.z, 0); }
    public static Vector4 Swizzle_zwz1(this Vector4 a) { return new Vector4(a.z, a.w, a.z, 1); }
    public static Vector4 Swizzle_zwwx(this Vector4 a) { return new Vector4(a.z, a.w, a.w, a.x); }
    public static Vector4 Swizzle_zwwy(this Vector4 a) { return new Vector4(a.z, a.w, a.w, a.y); }
    public static Vector4 Swizzle_zwwz(this Vector4 a) { return new Vector4(a.z, a.w, a.w, a.z); }
    public static Vector4 Swizzle_zwww(this Vector4 a) { return new Vector4(a.z, a.w, a.w, a.w); }
    public static Vector4 Swizzle_zww0(this Vector4 a) { return new Vector4(a.z, a.w, a.w, 0); }
    public static Vector4 Swizzle_zww1(this Vector4 a) { return new Vector4(a.z, a.w, a.w, 1); }
    public static Vector4 Swizzle_zw0x(this Vector4 a) { return new Vector4(a.z, a.w, 0, a.x); }
    public static Vector4 Swizzle_zw0y(this Vector4 a) { return new Vector4(a.z, a.w, 0, a.y); }
    public static Vector4 Swizzle_zw0z(this Vector4 a) { return new Vector4(a.z, a.w, 0, a.z); }
    public static Vector4 Swizzle_zw0w(this Vector4 a) { return new Vector4(a.z, a.w, 0, a.w); }
    public static Vector4 Swizzle_zw00(this Vector4 a) { return new Vector4(a.z, a.w, 0, 0); }
    public static Vector4 Swizzle_zw01(this Vector4 a) { return new Vector4(a.z, a.w, 0, 1); }
    public static Vector4 Swizzle_zw1x(this Vector4 a) { return new Vector4(a.z, a.w, 1, a.x); }
    public static Vector4 Swizzle_zw1y(this Vector4 a) { return new Vector4(a.z, a.w, 1, a.y); }
    public static Vector4 Swizzle_zw1z(this Vector4 a) { return new Vector4(a.z, a.w, 1, a.z); }
    public static Vector4 Swizzle_zw1w(this Vector4 a) { return new Vector4(a.z, a.w, 1, a.w); }
    public static Vector4 Swizzle_zw10(this Vector4 a) { return new Vector4(a.z, a.w, 1, 0); }
    public static Vector4 Swizzle_zw11(this Vector4 a) { return new Vector4(a.z, a.w, 1, 1); }
    public static Vector4 Swizzle_z0xx(this Vector4 a) { return new Vector4(a.z, 0, a.x, a.x); }
    public static Vector4 Swizzle_z0xy(this Vector4 a) { return new Vector4(a.z, 0, a.x, a.y); }
    public static Vector4 Swizzle_z0xz(this Vector4 a) { return new Vector4(a.z, 0, a.x, a.z); }
    public static Vector4 Swizzle_z0xw(this Vector4 a) { return new Vector4(a.z, 0, a.x, a.w); }
    public static Vector4 Swizzle_z0x0(this Vector4 a) { return new Vector4(a.z, 0, a.x, 0); }
    public static Vector4 Swizzle_z0x1(this Vector4 a) { return new Vector4(a.z, 0, a.x, 1); }
    public static Vector4 Swizzle_z0yx(this Vector4 a) { return new Vector4(a.z, 0, a.y, a.x); }
    public static Vector4 Swizzle_z0yy(this Vector4 a) { return new Vector4(a.z, 0, a.y, a.y); }
    public static Vector4 Swizzle_z0yz(this Vector4 a) { return new Vector4(a.z, 0, a.y, a.z); }
    public static Vector4 Swizzle_z0yw(this Vector4 a) { return new Vector4(a.z, 0, a.y, a.w); }
    public static Vector4 Swizzle_z0y0(this Vector4 a) { return new Vector4(a.z, 0, a.y, 0); }
    public static Vector4 Swizzle_z0y1(this Vector4 a) { return new Vector4(a.z, 0, a.y, 1); }
    public static Vector4 Swizzle_z0zx(this Vector4 a) { return new Vector4(a.z, 0, a.z, a.x); }
    public static Vector4 Swizzle_z0zy(this Vector4 a) { return new Vector4(a.z, 0, a.z, a.y); }
    public static Vector4 Swizzle_z0zz(this Vector4 a) { return new Vector4(a.z, 0, a.z, a.z); }
    public static Vector4 Swizzle_z0zw(this Vector4 a) { return new Vector4(a.z, 0, a.z, a.w); }
    public static Vector4 Swizzle_z0z0(this Vector4 a) { return new Vector4(a.z, 0, a.z, 0); }
    public static Vector4 Swizzle_z0z1(this Vector4 a) { return new Vector4(a.z, 0, a.z, 1); }
    public static Vector4 Swizzle_z0wx(this Vector4 a) { return new Vector4(a.z, 0, a.w, a.x); }
    public static Vector4 Swizzle_z0wy(this Vector4 a) { return new Vector4(a.z, 0, a.w, a.y); }
    public static Vector4 Swizzle_z0wz(this Vector4 a) { return new Vector4(a.z, 0, a.w, a.z); }
    public static Vector4 Swizzle_z0ww(this Vector4 a) { return new Vector4(a.z, 0, a.w, a.w); }
    public static Vector4 Swizzle_z0w0(this Vector4 a) { return new Vector4(a.z, 0, a.w, 0); }
    public static Vector4 Swizzle_z0w1(this Vector4 a) { return new Vector4(a.z, 0, a.w, 1); }
    public static Vector4 Swizzle_z00x(this Vector4 a) { return new Vector4(a.z, 0, 0, a.x); }
    public static Vector4 Swizzle_z00y(this Vector4 a) { return new Vector4(a.z, 0, 0, a.y); }
    public static Vector4 Swizzle_z00z(this Vector4 a) { return new Vector4(a.z, 0, 0, a.z); }
    public static Vector4 Swizzle_z00w(this Vector4 a) { return new Vector4(a.z, 0, 0, a.w); }
    public static Vector4 Swizzle_z000(this Vector4 a) { return new Vector4(a.z, 0, 0, 0); }
    public static Vector4 Swizzle_z001(this Vector4 a) { return new Vector4(a.z, 0, 0, 1); }
    public static Vector4 Swizzle_z01x(this Vector4 a) { return new Vector4(a.z, 0, 1, a.x); }
    public static Vector4 Swizzle_z01y(this Vector4 a) { return new Vector4(a.z, 0, 1, a.y); }
    public static Vector4 Swizzle_z01z(this Vector4 a) { return new Vector4(a.z, 0, 1, a.z); }
    public static Vector4 Swizzle_z01w(this Vector4 a) { return new Vector4(a.z, 0, 1, a.w); }
    public static Vector4 Swizzle_z010(this Vector4 a) { return new Vector4(a.z, 0, 1, 0); }
    public static Vector4 Swizzle_z011(this Vector4 a) { return new Vector4(a.z, 0, 1, 1); }
    public static Vector4 Swizzle_z1xx(this Vector4 a) { return new Vector4(a.z, 1, a.x, a.x); }
    public static Vector4 Swizzle_z1xy(this Vector4 a) { return new Vector4(a.z, 1, a.x, a.y); }
    public static Vector4 Swizzle_z1xz(this Vector4 a) { return new Vector4(a.z, 1, a.x, a.z); }
    public static Vector4 Swizzle_z1xw(this Vector4 a) { return new Vector4(a.z, 1, a.x, a.w); }
    public static Vector4 Swizzle_z1x0(this Vector4 a) { return new Vector4(a.z, 1, a.x, 0); }
    public static Vector4 Swizzle_z1x1(this Vector4 a) { return new Vector4(a.z, 1, a.x, 1); }
    public static Vector4 Swizzle_z1yx(this Vector4 a) { return new Vector4(a.z, 1, a.y, a.x); }
    public static Vector4 Swizzle_z1yy(this Vector4 a) { return new Vector4(a.z, 1, a.y, a.y); }
    public static Vector4 Swizzle_z1yz(this Vector4 a) { return new Vector4(a.z, 1, a.y, a.z); }
    public static Vector4 Swizzle_z1yw(this Vector4 a) { return new Vector4(a.z, 1, a.y, a.w); }
    public static Vector4 Swizzle_z1y0(this Vector4 a) { return new Vector4(a.z, 1, a.y, 0); }
    public static Vector4 Swizzle_z1y1(this Vector4 a) { return new Vector4(a.z, 1, a.y, 1); }
    public static Vector4 Swizzle_z1zx(this Vector4 a) { return new Vector4(a.z, 1, a.z, a.x); }
    public static Vector4 Swizzle_z1zy(this Vector4 a) { return new Vector4(a.z, 1, a.z, a.y); }
    public static Vector4 Swizzle_z1zz(this Vector4 a) { return new Vector4(a.z, 1, a.z, a.z); }
    public static Vector4 Swizzle_z1zw(this Vector4 a) { return new Vector4(a.z, 1, a.z, a.w); }
    public static Vector4 Swizzle_z1z0(this Vector4 a) { return new Vector4(a.z, 1, a.z, 0); }
    public static Vector4 Swizzle_z1z1(this Vector4 a) { return new Vector4(a.z, 1, a.z, 1); }
    public static Vector4 Swizzle_z1wx(this Vector4 a) { return new Vector4(a.z, 1, a.w, a.x); }
    public static Vector4 Swizzle_z1wy(this Vector4 a) { return new Vector4(a.z, 1, a.w, a.y); }
    public static Vector4 Swizzle_z1wz(this Vector4 a) { return new Vector4(a.z, 1, a.w, a.z); }
    public static Vector4 Swizzle_z1ww(this Vector4 a) { return new Vector4(a.z, 1, a.w, a.w); }
    public static Vector4 Swizzle_z1w0(this Vector4 a) { return new Vector4(a.z, 1, a.w, 0); }
    public static Vector4 Swizzle_z1w1(this Vector4 a) { return new Vector4(a.z, 1, a.w, 1); }
    public static Vector4 Swizzle_z10x(this Vector4 a) { return new Vector4(a.z, 1, 0, a.x); }
    public static Vector4 Swizzle_z10y(this Vector4 a) { return new Vector4(a.z, 1, 0, a.y); }
    public static Vector4 Swizzle_z10z(this Vector4 a) { return new Vector4(a.z, 1, 0, a.z); }
    public static Vector4 Swizzle_z10w(this Vector4 a) { return new Vector4(a.z, 1, 0, a.w); }
    public static Vector4 Swizzle_z100(this Vector4 a) { return new Vector4(a.z, 1, 0, 0); }
    public static Vector4 Swizzle_z101(this Vector4 a) { return new Vector4(a.z, 1, 0, 1); }
    public static Vector4 Swizzle_z11x(this Vector4 a) { return new Vector4(a.z, 1, 1, a.x); }
    public static Vector4 Swizzle_z11y(this Vector4 a) { return new Vector4(a.z, 1, 1, a.y); }
    public static Vector4 Swizzle_z11z(this Vector4 a) { return new Vector4(a.z, 1, 1, a.z); }
    public static Vector4 Swizzle_z11w(this Vector4 a) { return new Vector4(a.z, 1, 1, a.w); }
    public static Vector4 Swizzle_z110(this Vector4 a) { return new Vector4(a.z, 1, 1, 0); }
    public static Vector4 Swizzle_z111(this Vector4 a) { return new Vector4(a.z, 1, 1, 1); }
    public static Vector4 Swizzle_wxxx(this Vector4 a) { return new Vector4(a.w, a.x, a.x, a.x); }
    public static Vector4 Swizzle_wxxy(this Vector4 a) { return new Vector4(a.w, a.x, a.x, a.y); }
    public static Vector4 Swizzle_wxxz(this Vector4 a) { return new Vector4(a.w, a.x, a.x, a.z); }
    public static Vector4 Swizzle_wxxw(this Vector4 a) { return new Vector4(a.w, a.x, a.x, a.w); }
    public static Vector4 Swizzle_wxx0(this Vector4 a) { return new Vector4(a.w, a.x, a.x, 0); }
    public static Vector4 Swizzle_wxx1(this Vector4 a) { return new Vector4(a.w, a.x, a.x, 1); }
    public static Vector4 Swizzle_wxyx(this Vector4 a) { return new Vector4(a.w, a.x, a.y, a.x); }
    public static Vector4 Swizzle_wxyy(this Vector4 a) { return new Vector4(a.w, a.x, a.y, a.y); }
    public static Vector4 Swizzle_wxyz(this Vector4 a) { return new Vector4(a.w, a.x, a.y, a.z); }
    public static Vector4 Swizzle_wxyw(this Vector4 a) { return new Vector4(a.w, a.x, a.y, a.w); }
    public static Vector4 Swizzle_wxy0(this Vector4 a) { return new Vector4(a.w, a.x, a.y, 0); }
    public static Vector4 Swizzle_wxy1(this Vector4 a) { return new Vector4(a.w, a.x, a.y, 1); }
    public static Vector4 Swizzle_wxzx(this Vector4 a) { return new Vector4(a.w, a.x, a.z, a.x); }
    public static Vector4 Swizzle_wxzy(this Vector4 a) { return new Vector4(a.w, a.x, a.z, a.y); }
    public static Vector4 Swizzle_wxzz(this Vector4 a) { return new Vector4(a.w, a.x, a.z, a.z); }
    public static Vector4 Swizzle_wxzw(this Vector4 a) { return new Vector4(a.w, a.x, a.z, a.w); }
    public static Vector4 Swizzle_wxz0(this Vector4 a) { return new Vector4(a.w, a.x, a.z, 0); }
    public static Vector4 Swizzle_wxz1(this Vector4 a) { return new Vector4(a.w, a.x, a.z, 1); }
    public static Vector4 Swizzle_wxwx(this Vector4 a) { return new Vector4(a.w, a.x, a.w, a.x); }
    public static Vector4 Swizzle_wxwy(this Vector4 a) { return new Vector4(a.w, a.x, a.w, a.y); }
    public static Vector4 Swizzle_wxwz(this Vector4 a) { return new Vector4(a.w, a.x, a.w, a.z); }
    public static Vector4 Swizzle_wxww(this Vector4 a) { return new Vector4(a.w, a.x, a.w, a.w); }
    public static Vector4 Swizzle_wxw0(this Vector4 a) { return new Vector4(a.w, a.x, a.w, 0); }
    public static Vector4 Swizzle_wxw1(this Vector4 a) { return new Vector4(a.w, a.x, a.w, 1); }
    public static Vector4 Swizzle_wx0x(this Vector4 a) { return new Vector4(a.w, a.x, 0, a.x); }
    public static Vector4 Swizzle_wx0y(this Vector4 a) { return new Vector4(a.w, a.x, 0, a.y); }
    public static Vector4 Swizzle_wx0z(this Vector4 a) { return new Vector4(a.w, a.x, 0, a.z); }
    public static Vector4 Swizzle_wx0w(this Vector4 a) { return new Vector4(a.w, a.x, 0, a.w); }
    public static Vector4 Swizzle_wx00(this Vector4 a) { return new Vector4(a.w, a.x, 0, 0); }
    public static Vector4 Swizzle_wx01(this Vector4 a) { return new Vector4(a.w, a.x, 0, 1); }
    public static Vector4 Swizzle_wx1x(this Vector4 a) { return new Vector4(a.w, a.x, 1, a.x); }
    public static Vector4 Swizzle_wx1y(this Vector4 a) { return new Vector4(a.w, a.x, 1, a.y); }
    public static Vector4 Swizzle_wx1z(this Vector4 a) { return new Vector4(a.w, a.x, 1, a.z); }
    public static Vector4 Swizzle_wx1w(this Vector4 a) { return new Vector4(a.w, a.x, 1, a.w); }
    public static Vector4 Swizzle_wx10(this Vector4 a) { return new Vector4(a.w, a.x, 1, 0); }
    public static Vector4 Swizzle_wx11(this Vector4 a) { return new Vector4(a.w, a.x, 1, 1); }
    public static Vector4 Swizzle_wyxx(this Vector4 a) { return new Vector4(a.w, a.y, a.x, a.x); }
    public static Vector4 Swizzle_wyxy(this Vector4 a) { return new Vector4(a.w, a.y, a.x, a.y); }
    public static Vector4 Swizzle_wyxz(this Vector4 a) { return new Vector4(a.w, a.y, a.x, a.z); }
    public static Vector4 Swizzle_wyxw(this Vector4 a) { return new Vector4(a.w, a.y, a.x, a.w); }
    public static Vector4 Swizzle_wyx0(this Vector4 a) { return new Vector4(a.w, a.y, a.x, 0); }
    public static Vector4 Swizzle_wyx1(this Vector4 a) { return new Vector4(a.w, a.y, a.x, 1); }
    public static Vector4 Swizzle_wyyx(this Vector4 a) { return new Vector4(a.w, a.y, a.y, a.x); }
    public static Vector4 Swizzle_wyyy(this Vector4 a) { return new Vector4(a.w, a.y, a.y, a.y); }
    public static Vector4 Swizzle_wyyz(this Vector4 a) { return new Vector4(a.w, a.y, a.y, a.z); }
    public static Vector4 Swizzle_wyyw(this Vector4 a) { return new Vector4(a.w, a.y, a.y, a.w); }
    public static Vector4 Swizzle_wyy0(this Vector4 a) { return new Vector4(a.w, a.y, a.y, 0); }
    public static Vector4 Swizzle_wyy1(this Vector4 a) { return new Vector4(a.w, a.y, a.y, 1); }
    public static Vector4 Swizzle_wyzx(this Vector4 a) { return new Vector4(a.w, a.y, a.z, a.x); }
    public static Vector4 Swizzle_wyzy(this Vector4 a) { return new Vector4(a.w, a.y, a.z, a.y); }
    public static Vector4 Swizzle_wyzz(this Vector4 a) { return new Vector4(a.w, a.y, a.z, a.z); }
    public static Vector4 Swizzle_wyzw(this Vector4 a) { return new Vector4(a.w, a.y, a.z, a.w); }
    public static Vector4 Swizzle_wyz0(this Vector4 a) { return new Vector4(a.w, a.y, a.z, 0); }
    public static Vector4 Swizzle_wyz1(this Vector4 a) { return new Vector4(a.w, a.y, a.z, 1); }
    public static Vector4 Swizzle_wywx(this Vector4 a) { return new Vector4(a.w, a.y, a.w, a.x); }
    public static Vector4 Swizzle_wywy(this Vector4 a) { return new Vector4(a.w, a.y, a.w, a.y); }
    public static Vector4 Swizzle_wywz(this Vector4 a) { return new Vector4(a.w, a.y, a.w, a.z); }
    public static Vector4 Swizzle_wyww(this Vector4 a) { return new Vector4(a.w, a.y, a.w, a.w); }
    public static Vector4 Swizzle_wyw0(this Vector4 a) { return new Vector4(a.w, a.y, a.w, 0); }
    public static Vector4 Swizzle_wyw1(this Vector4 a) { return new Vector4(a.w, a.y, a.w, 1); }
    public static Vector4 Swizzle_wy0x(this Vector4 a) { return new Vector4(a.w, a.y, 0, a.x); }
    public static Vector4 Swizzle_wy0y(this Vector4 a) { return new Vector4(a.w, a.y, 0, a.y); }
    public static Vector4 Swizzle_wy0z(this Vector4 a) { return new Vector4(a.w, a.y, 0, a.z); }
    public static Vector4 Swizzle_wy0w(this Vector4 a) { return new Vector4(a.w, a.y, 0, a.w); }
    public static Vector4 Swizzle_wy00(this Vector4 a) { return new Vector4(a.w, a.y, 0, 0); }
    public static Vector4 Swizzle_wy01(this Vector4 a) { return new Vector4(a.w, a.y, 0, 1); }
    public static Vector4 Swizzle_wy1x(this Vector4 a) { return new Vector4(a.w, a.y, 1, a.x); }
    public static Vector4 Swizzle_wy1y(this Vector4 a) { return new Vector4(a.w, a.y, 1, a.y); }
    public static Vector4 Swizzle_wy1z(this Vector4 a) { return new Vector4(a.w, a.y, 1, a.z); }
    public static Vector4 Swizzle_wy1w(this Vector4 a) { return new Vector4(a.w, a.y, 1, a.w); }
    public static Vector4 Swizzle_wy10(this Vector4 a) { return new Vector4(a.w, a.y, 1, 0); }
    public static Vector4 Swizzle_wy11(this Vector4 a) { return new Vector4(a.w, a.y, 1, 1); }
    public static Vector4 Swizzle_wzxx(this Vector4 a) { return new Vector4(a.w, a.z, a.x, a.x); }
    public static Vector4 Swizzle_wzxy(this Vector4 a) { return new Vector4(a.w, a.z, a.x, a.y); }
    public static Vector4 Swizzle_wzxz(this Vector4 a) { return new Vector4(a.w, a.z, a.x, a.z); }
    public static Vector4 Swizzle_wzxw(this Vector4 a) { return new Vector4(a.w, a.z, a.x, a.w); }
    public static Vector4 Swizzle_wzx0(this Vector4 a) { return new Vector4(a.w, a.z, a.x, 0); }
    public static Vector4 Swizzle_wzx1(this Vector4 a) { return new Vector4(a.w, a.z, a.x, 1); }
    public static Vector4 Swizzle_wzyx(this Vector4 a) { return new Vector4(a.w, a.z, a.y, a.x); }
    public static Vector4 Swizzle_wzyy(this Vector4 a) { return new Vector4(a.w, a.z, a.y, a.y); }
    public static Vector4 Swizzle_wzyz(this Vector4 a) { return new Vector4(a.w, a.z, a.y, a.z); }
    public static Vector4 Swizzle_wzyw(this Vector4 a) { return new Vector4(a.w, a.z, a.y, a.w); }
    public static Vector4 Swizzle_wzy0(this Vector4 a) { return new Vector4(a.w, a.z, a.y, 0); }
    public static Vector4 Swizzle_wzy1(this Vector4 a) { return new Vector4(a.w, a.z, a.y, 1); }
    public static Vector4 Swizzle_wzzx(this Vector4 a) { return new Vector4(a.w, a.z, a.z, a.x); }
    public static Vector4 Swizzle_wzzy(this Vector4 a) { return new Vector4(a.w, a.z, a.z, a.y); }
    public static Vector4 Swizzle_wzzz(this Vector4 a) { return new Vector4(a.w, a.z, a.z, a.z); }
    public static Vector4 Swizzle_wzzw(this Vector4 a) { return new Vector4(a.w, a.z, a.z, a.w); }
    public static Vector4 Swizzle_wzz0(this Vector4 a) { return new Vector4(a.w, a.z, a.z, 0); }
    public static Vector4 Swizzle_wzz1(this Vector4 a) { return new Vector4(a.w, a.z, a.z, 1); }
    public static Vector4 Swizzle_wzwx(this Vector4 a) { return new Vector4(a.w, a.z, a.w, a.x); }
    public static Vector4 Swizzle_wzwy(this Vector4 a) { return new Vector4(a.w, a.z, a.w, a.y); }
    public static Vector4 Swizzle_wzwz(this Vector4 a) { return new Vector4(a.w, a.z, a.w, a.z); }
    public static Vector4 Swizzle_wzww(this Vector4 a) { return new Vector4(a.w, a.z, a.w, a.w); }
    public static Vector4 Swizzle_wzw0(this Vector4 a) { return new Vector4(a.w, a.z, a.w, 0); }
    public static Vector4 Swizzle_wzw1(this Vector4 a) { return new Vector4(a.w, a.z, a.w, 1); }
    public static Vector4 Swizzle_wz0x(this Vector4 a) { return new Vector4(a.w, a.z, 0, a.x); }
    public static Vector4 Swizzle_wz0y(this Vector4 a) { return new Vector4(a.w, a.z, 0, a.y); }
    public static Vector4 Swizzle_wz0z(this Vector4 a) { return new Vector4(a.w, a.z, 0, a.z); }
    public static Vector4 Swizzle_wz0w(this Vector4 a) { return new Vector4(a.w, a.z, 0, a.w); }
    public static Vector4 Swizzle_wz00(this Vector4 a) { return new Vector4(a.w, a.z, 0, 0); }
    public static Vector4 Swizzle_wz01(this Vector4 a) { return new Vector4(a.w, a.z, 0, 1); }
    public static Vector4 Swizzle_wz1x(this Vector4 a) { return new Vector4(a.w, a.z, 1, a.x); }
    public static Vector4 Swizzle_wz1y(this Vector4 a) { return new Vector4(a.w, a.z, 1, a.y); }
    public static Vector4 Swizzle_wz1z(this Vector4 a) { return new Vector4(a.w, a.z, 1, a.z); }
    public static Vector4 Swizzle_wz1w(this Vector4 a) { return new Vector4(a.w, a.z, 1, a.w); }
    public static Vector4 Swizzle_wz10(this Vector4 a) { return new Vector4(a.w, a.z, 1, 0); }
    public static Vector4 Swizzle_wz11(this Vector4 a) { return new Vector4(a.w, a.z, 1, 1); }
    public static Vector4 Swizzle_wwxx(this Vector4 a) { return new Vector4(a.w, a.w, a.x, a.x); }
    public static Vector4 Swizzle_wwxy(this Vector4 a) { return new Vector4(a.w, a.w, a.x, a.y); }
    public static Vector4 Swizzle_wwxz(this Vector4 a) { return new Vector4(a.w, a.w, a.x, a.z); }
    public static Vector4 Swizzle_wwxw(this Vector4 a) { return new Vector4(a.w, a.w, a.x, a.w); }
    public static Vector4 Swizzle_wwx0(this Vector4 a) { return new Vector4(a.w, a.w, a.x, 0); }
    public static Vector4 Swizzle_wwx1(this Vector4 a) { return new Vector4(a.w, a.w, a.x, 1); }
    public static Vector4 Swizzle_wwyx(this Vector4 a) { return new Vector4(a.w, a.w, a.y, a.x); }
    public static Vector4 Swizzle_wwyy(this Vector4 a) { return new Vector4(a.w, a.w, a.y, a.y); }
    public static Vector4 Swizzle_wwyz(this Vector4 a) { return new Vector4(a.w, a.w, a.y, a.z); }
    public static Vector4 Swizzle_wwyw(this Vector4 a) { return new Vector4(a.w, a.w, a.y, a.w); }
    public static Vector4 Swizzle_wwy0(this Vector4 a) { return new Vector4(a.w, a.w, a.y, 0); }
    public static Vector4 Swizzle_wwy1(this Vector4 a) { return new Vector4(a.w, a.w, a.y, 1); }
    public static Vector4 Swizzle_wwzx(this Vector4 a) { return new Vector4(a.w, a.w, a.z, a.x); }
    public static Vector4 Swizzle_wwzy(this Vector4 a) { return new Vector4(a.w, a.w, a.z, a.y); }
    public static Vector4 Swizzle_wwzz(this Vector4 a) { return new Vector4(a.w, a.w, a.z, a.z); }
    public static Vector4 Swizzle_wwzw(this Vector4 a) { return new Vector4(a.w, a.w, a.z, a.w); }
    public static Vector4 Swizzle_wwz0(this Vector4 a) { return new Vector4(a.w, a.w, a.z, 0); }
    public static Vector4 Swizzle_wwz1(this Vector4 a) { return new Vector4(a.w, a.w, a.z, 1); }
    public static Vector4 Swizzle_wwwx(this Vector4 a) { return new Vector4(a.w, a.w, a.w, a.x); }
    public static Vector4 Swizzle_wwwy(this Vector4 a) { return new Vector4(a.w, a.w, a.w, a.y); }
    public static Vector4 Swizzle_wwwz(this Vector4 a) { return new Vector4(a.w, a.w, a.w, a.z); }
    public static Vector4 Swizzle_wwww(this Vector4 a) { return new Vector4(a.w, a.w, a.w, a.w); }
    public static Vector4 Swizzle_www0(this Vector4 a) { return new Vector4(a.w, a.w, a.w, 0); }
    public static Vector4 Swizzle_www1(this Vector4 a) { return new Vector4(a.w, a.w, a.w, 1); }
    public static Vector4 Swizzle_ww0x(this Vector4 a) { return new Vector4(a.w, a.w, 0, a.x); }
    public static Vector4 Swizzle_ww0y(this Vector4 a) { return new Vector4(a.w, a.w, 0, a.y); }
    public static Vector4 Swizzle_ww0z(this Vector4 a) { return new Vector4(a.w, a.w, 0, a.z); }
    public static Vector4 Swizzle_ww0w(this Vector4 a) { return new Vector4(a.w, a.w, 0, a.w); }
    public static Vector4 Swizzle_ww00(this Vector4 a) { return new Vector4(a.w, a.w, 0, 0); }
    public static Vector4 Swizzle_ww01(this Vector4 a) { return new Vector4(a.w, a.w, 0, 1); }
    public static Vector4 Swizzle_ww1x(this Vector4 a) { return new Vector4(a.w, a.w, 1, a.x); }
    public static Vector4 Swizzle_ww1y(this Vector4 a) { return new Vector4(a.w, a.w, 1, a.y); }
    public static Vector4 Swizzle_ww1z(this Vector4 a) { return new Vector4(a.w, a.w, 1, a.z); }
    public static Vector4 Swizzle_ww1w(this Vector4 a) { return new Vector4(a.w, a.w, 1, a.w); }
    public static Vector4 Swizzle_ww10(this Vector4 a) { return new Vector4(a.w, a.w, 1, 0); }
    public static Vector4 Swizzle_ww11(this Vector4 a) { return new Vector4(a.w, a.w, 1, 1); }
    public static Vector4 Swizzle_w0xx(this Vector4 a) { return new Vector4(a.w, 0, a.x, a.x); }
    public static Vector4 Swizzle_w0xy(this Vector4 a) { return new Vector4(a.w, 0, a.x, a.y); }
    public static Vector4 Swizzle_w0xz(this Vector4 a) { return new Vector4(a.w, 0, a.x, a.z); }
    public static Vector4 Swizzle_w0xw(this Vector4 a) { return new Vector4(a.w, 0, a.x, a.w); }
    public static Vector4 Swizzle_w0x0(this Vector4 a) { return new Vector4(a.w, 0, a.x, 0); }
    public static Vector4 Swizzle_w0x1(this Vector4 a) { return new Vector4(a.w, 0, a.x, 1); }
    public static Vector4 Swizzle_w0yx(this Vector4 a) { return new Vector4(a.w, 0, a.y, a.x); }
    public static Vector4 Swizzle_w0yy(this Vector4 a) { return new Vector4(a.w, 0, a.y, a.y); }
    public static Vector4 Swizzle_w0yz(this Vector4 a) { return new Vector4(a.w, 0, a.y, a.z); }
    public static Vector4 Swizzle_w0yw(this Vector4 a) { return new Vector4(a.w, 0, a.y, a.w); }
    public static Vector4 Swizzle_w0y0(this Vector4 a) { return new Vector4(a.w, 0, a.y, 0); }
    public static Vector4 Swizzle_w0y1(this Vector4 a) { return new Vector4(a.w, 0, a.y, 1); }
    public static Vector4 Swizzle_w0zx(this Vector4 a) { return new Vector4(a.w, 0, a.z, a.x); }
    public static Vector4 Swizzle_w0zy(this Vector4 a) { return new Vector4(a.w, 0, a.z, a.y); }
    public static Vector4 Swizzle_w0zz(this Vector4 a) { return new Vector4(a.w, 0, a.z, a.z); }
    public static Vector4 Swizzle_w0zw(this Vector4 a) { return new Vector4(a.w, 0, a.z, a.w); }
    public static Vector4 Swizzle_w0z0(this Vector4 a) { return new Vector4(a.w, 0, a.z, 0); }
    public static Vector4 Swizzle_w0z1(this Vector4 a) { return new Vector4(a.w, 0, a.z, 1); }
    public static Vector4 Swizzle_w0wx(this Vector4 a) { return new Vector4(a.w, 0, a.w, a.x); }
    public static Vector4 Swizzle_w0wy(this Vector4 a) { return new Vector4(a.w, 0, a.w, a.y); }
    public static Vector4 Swizzle_w0wz(this Vector4 a) { return new Vector4(a.w, 0, a.w, a.z); }
    public static Vector4 Swizzle_w0ww(this Vector4 a) { return new Vector4(a.w, 0, a.w, a.w); }
    public static Vector4 Swizzle_w0w0(this Vector4 a) { return new Vector4(a.w, 0, a.w, 0); }
    public static Vector4 Swizzle_w0w1(this Vector4 a) { return new Vector4(a.w, 0, a.w, 1); }
    public static Vector4 Swizzle_w00x(this Vector4 a) { return new Vector4(a.w, 0, 0, a.x); }
    public static Vector4 Swizzle_w00y(this Vector4 a) { return new Vector4(a.w, 0, 0, a.y); }
    public static Vector4 Swizzle_w00z(this Vector4 a) { return new Vector4(a.w, 0, 0, a.z); }
    public static Vector4 Swizzle_w00w(this Vector4 a) { return new Vector4(a.w, 0, 0, a.w); }
    public static Vector4 Swizzle_w000(this Vector4 a) { return new Vector4(a.w, 0, 0, 0); }
    public static Vector4 Swizzle_w001(this Vector4 a) { return new Vector4(a.w, 0, 0, 1); }
    public static Vector4 Swizzle_w01x(this Vector4 a) { return new Vector4(a.w, 0, 1, a.x); }
    public static Vector4 Swizzle_w01y(this Vector4 a) { return new Vector4(a.w, 0, 1, a.y); }
    public static Vector4 Swizzle_w01z(this Vector4 a) { return new Vector4(a.w, 0, 1, a.z); }
    public static Vector4 Swizzle_w01w(this Vector4 a) { return new Vector4(a.w, 0, 1, a.w); }
    public static Vector4 Swizzle_w010(this Vector4 a) { return new Vector4(a.w, 0, 1, 0); }
    public static Vector4 Swizzle_w011(this Vector4 a) { return new Vector4(a.w, 0, 1, 1); }
    public static Vector4 Swizzle_w1xx(this Vector4 a) { return new Vector4(a.w, 1, a.x, a.x); }
    public static Vector4 Swizzle_w1xy(this Vector4 a) { return new Vector4(a.w, 1, a.x, a.y); }
    public static Vector4 Swizzle_w1xz(this Vector4 a) { return new Vector4(a.w, 1, a.x, a.z); }
    public static Vector4 Swizzle_w1xw(this Vector4 a) { return new Vector4(a.w, 1, a.x, a.w); }
    public static Vector4 Swizzle_w1x0(this Vector4 a) { return new Vector4(a.w, 1, a.x, 0); }
    public static Vector4 Swizzle_w1x1(this Vector4 a) { return new Vector4(a.w, 1, a.x, 1); }
    public static Vector4 Swizzle_w1yx(this Vector4 a) { return new Vector4(a.w, 1, a.y, a.x); }
    public static Vector4 Swizzle_w1yy(this Vector4 a) { return new Vector4(a.w, 1, a.y, a.y); }
    public static Vector4 Swizzle_w1yz(this Vector4 a) { return new Vector4(a.w, 1, a.y, a.z); }
    public static Vector4 Swizzle_w1yw(this Vector4 a) { return new Vector4(a.w, 1, a.y, a.w); }
    public static Vector4 Swizzle_w1y0(this Vector4 a) { return new Vector4(a.w, 1, a.y, 0); }
    public static Vector4 Swizzle_w1y1(this Vector4 a) { return new Vector4(a.w, 1, a.y, 1); }
    public static Vector4 Swizzle_w1zx(this Vector4 a) { return new Vector4(a.w, 1, a.z, a.x); }
    public static Vector4 Swizzle_w1zy(this Vector4 a) { return new Vector4(a.w, 1, a.z, a.y); }
    public static Vector4 Swizzle_w1zz(this Vector4 a) { return new Vector4(a.w, 1, a.z, a.z); }
    public static Vector4 Swizzle_w1zw(this Vector4 a) { return new Vector4(a.w, 1, a.z, a.w); }
    public static Vector4 Swizzle_w1z0(this Vector4 a) { return new Vector4(a.w, 1, a.z, 0); }
    public static Vector4 Swizzle_w1z1(this Vector4 a) { return new Vector4(a.w, 1, a.z, 1); }
    public static Vector4 Swizzle_w1wx(this Vector4 a) { return new Vector4(a.w, 1, a.w, a.x); }
    public static Vector4 Swizzle_w1wy(this Vector4 a) { return new Vector4(a.w, 1, a.w, a.y); }
    public static Vector4 Swizzle_w1wz(this Vector4 a) { return new Vector4(a.w, 1, a.w, a.z); }
    public static Vector4 Swizzle_w1ww(this Vector4 a) { return new Vector4(a.w, 1, a.w, a.w); }
    public static Vector4 Swizzle_w1w0(this Vector4 a) { return new Vector4(a.w, 1, a.w, 0); }
    public static Vector4 Swizzle_w1w1(this Vector4 a) { return new Vector4(a.w, 1, a.w, 1); }
    public static Vector4 Swizzle_w10x(this Vector4 a) { return new Vector4(a.w, 1, 0, a.x); }
    public static Vector4 Swizzle_w10y(this Vector4 a) { return new Vector4(a.w, 1, 0, a.y); }
    public static Vector4 Swizzle_w10z(this Vector4 a) { return new Vector4(a.w, 1, 0, a.z); }
    public static Vector4 Swizzle_w10w(this Vector4 a) { return new Vector4(a.w, 1, 0, a.w); }
    public static Vector4 Swizzle_w100(this Vector4 a) { return new Vector4(a.w, 1, 0, 0); }
    public static Vector4 Swizzle_w101(this Vector4 a) { return new Vector4(a.w, 1, 0, 1); }
    public static Vector4 Swizzle_w11x(this Vector4 a) { return new Vector4(a.w, 1, 1, a.x); }
    public static Vector4 Swizzle_w11y(this Vector4 a) { return new Vector4(a.w, 1, 1, a.y); }
    public static Vector4 Swizzle_w11z(this Vector4 a) { return new Vector4(a.w, 1, 1, a.z); }
    public static Vector4 Swizzle_w11w(this Vector4 a) { return new Vector4(a.w, 1, 1, a.w); }
    public static Vector4 Swizzle_w110(this Vector4 a) { return new Vector4(a.w, 1, 1, 0); }
    public static Vector4 Swizzle_w111(this Vector4 a) { return new Vector4(a.w, 1, 1, 1); }
    public static Vector4 Swizzle_0xxx(this Vector4 a) { return new Vector4(0, a.x, a.x, a.x); }
    public static Vector4 Swizzle_0xxy(this Vector4 a) { return new Vector4(0, a.x, a.x, a.y); }
    public static Vector4 Swizzle_0xxz(this Vector4 a) { return new Vector4(0, a.x, a.x, a.z); }
    public static Vector4 Swizzle_0xxw(this Vector4 a) { return new Vector4(0, a.x, a.x, a.w); }
    public static Vector4 Swizzle_0xx0(this Vector4 a) { return new Vector4(0, a.x, a.x, 0); }
    public static Vector4 Swizzle_0xx1(this Vector4 a) { return new Vector4(0, a.x, a.x, 1); }
    public static Vector4 Swizzle_0xyx(this Vector4 a) { return new Vector4(0, a.x, a.y, a.x); }
    public static Vector4 Swizzle_0xyy(this Vector4 a) { return new Vector4(0, a.x, a.y, a.y); }
    public static Vector4 Swizzle_0xyz(this Vector4 a) { return new Vector4(0, a.x, a.y, a.z); }
    public static Vector4 Swizzle_0xyw(this Vector4 a) { return new Vector4(0, a.x, a.y, a.w); }
    public static Vector4 Swizzle_0xy0(this Vector4 a) { return new Vector4(0, a.x, a.y, 0); }
    public static Vector4 Swizzle_0xy1(this Vector4 a) { return new Vector4(0, a.x, a.y, 1); }
    public static Vector4 Swizzle_0xzx(this Vector4 a) { return new Vector4(0, a.x, a.z, a.x); }
    public static Vector4 Swizzle_0xzy(this Vector4 a) { return new Vector4(0, a.x, a.z, a.y); }
    public static Vector4 Swizzle_0xzz(this Vector4 a) { return new Vector4(0, a.x, a.z, a.z); }
    public static Vector4 Swizzle_0xzw(this Vector4 a) { return new Vector4(0, a.x, a.z, a.w); }
    public static Vector4 Swizzle_0xz0(this Vector4 a) { return new Vector4(0, a.x, a.z, 0); }
    public static Vector4 Swizzle_0xz1(this Vector4 a) { return new Vector4(0, a.x, a.z, 1); }
    public static Vector4 Swizzle_0xwx(this Vector4 a) { return new Vector4(0, a.x, a.w, a.x); }
    public static Vector4 Swizzle_0xwy(this Vector4 a) { return new Vector4(0, a.x, a.w, a.y); }
    public static Vector4 Swizzle_0xwz(this Vector4 a) { return new Vector4(0, a.x, a.w, a.z); }
    public static Vector4 Swizzle_0xww(this Vector4 a) { return new Vector4(0, a.x, a.w, a.w); }
    public static Vector4 Swizzle_0xw0(this Vector4 a) { return new Vector4(0, a.x, a.w, 0); }
    public static Vector4 Swizzle_0xw1(this Vector4 a) { return new Vector4(0, a.x, a.w, 1); }
    public static Vector4 Swizzle_0x0x(this Vector4 a) { return new Vector4(0, a.x, 0, a.x); }
    public static Vector4 Swizzle_0x0y(this Vector4 a) { return new Vector4(0, a.x, 0, a.y); }
    public static Vector4 Swizzle_0x0z(this Vector4 a) { return new Vector4(0, a.x, 0, a.z); }
    public static Vector4 Swizzle_0x0w(this Vector4 a) { return new Vector4(0, a.x, 0, a.w); }
    public static Vector4 Swizzle_0x00(this Vector4 a) { return new Vector4(0, a.x, 0, 0); }
    public static Vector4 Swizzle_0x01(this Vector4 a) { return new Vector4(0, a.x, 0, 1); }
    public static Vector4 Swizzle_0x1x(this Vector4 a) { return new Vector4(0, a.x, 1, a.x); }
    public static Vector4 Swizzle_0x1y(this Vector4 a) { return new Vector4(0, a.x, 1, a.y); }
    public static Vector4 Swizzle_0x1z(this Vector4 a) { return new Vector4(0, a.x, 1, a.z); }
    public static Vector4 Swizzle_0x1w(this Vector4 a) { return new Vector4(0, a.x, 1, a.w); }
    public static Vector4 Swizzle_0x10(this Vector4 a) { return new Vector4(0, a.x, 1, 0); }
    public static Vector4 Swizzle_0x11(this Vector4 a) { return new Vector4(0, a.x, 1, 1); }
    public static Vector4 Swizzle_0yxx(this Vector4 a) { return new Vector4(0, a.y, a.x, a.x); }
    public static Vector4 Swizzle_0yxy(this Vector4 a) { return new Vector4(0, a.y, a.x, a.y); }
    public static Vector4 Swizzle_0yxz(this Vector4 a) { return new Vector4(0, a.y, a.x, a.z); }
    public static Vector4 Swizzle_0yxw(this Vector4 a) { return new Vector4(0, a.y, a.x, a.w); }
    public static Vector4 Swizzle_0yx0(this Vector4 a) { return new Vector4(0, a.y, a.x, 0); }
    public static Vector4 Swizzle_0yx1(this Vector4 a) { return new Vector4(0, a.y, a.x, 1); }
    public static Vector4 Swizzle_0yyx(this Vector4 a) { return new Vector4(0, a.y, a.y, a.x); }
    public static Vector4 Swizzle_0yyy(this Vector4 a) { return new Vector4(0, a.y, a.y, a.y); }
    public static Vector4 Swizzle_0yyz(this Vector4 a) { return new Vector4(0, a.y, a.y, a.z); }
    public static Vector4 Swizzle_0yyw(this Vector4 a) { return new Vector4(0, a.y, a.y, a.w); }
    public static Vector4 Swizzle_0yy0(this Vector4 a) { return new Vector4(0, a.y, a.y, 0); }
    public static Vector4 Swizzle_0yy1(this Vector4 a) { return new Vector4(0, a.y, a.y, 1); }
    public static Vector4 Swizzle_0yzx(this Vector4 a) { return new Vector4(0, a.y, a.z, a.x); }
    public static Vector4 Swizzle_0yzy(this Vector4 a) { return new Vector4(0, a.y, a.z, a.y); }
    public static Vector4 Swizzle_0yzz(this Vector4 a) { return new Vector4(0, a.y, a.z, a.z); }
    public static Vector4 Swizzle_0yzw(this Vector4 a) { return new Vector4(0, a.y, a.z, a.w); }
    public static Vector4 Swizzle_0yz0(this Vector4 a) { return new Vector4(0, a.y, a.z, 0); }
    public static Vector4 Swizzle_0yz1(this Vector4 a) { return new Vector4(0, a.y, a.z, 1); }
    public static Vector4 Swizzle_0ywx(this Vector4 a) { return new Vector4(0, a.y, a.w, a.x); }
    public static Vector4 Swizzle_0ywy(this Vector4 a) { return new Vector4(0, a.y, a.w, a.y); }
    public static Vector4 Swizzle_0ywz(this Vector4 a) { return new Vector4(0, a.y, a.w, a.z); }
    public static Vector4 Swizzle_0yww(this Vector4 a) { return new Vector4(0, a.y, a.w, a.w); }
    public static Vector4 Swizzle_0yw0(this Vector4 a) { return new Vector4(0, a.y, a.w, 0); }
    public static Vector4 Swizzle_0yw1(this Vector4 a) { return new Vector4(0, a.y, a.w, 1); }
    public static Vector4 Swizzle_0y0x(this Vector4 a) { return new Vector4(0, a.y, 0, a.x); }
    public static Vector4 Swizzle_0y0y(this Vector4 a) { return new Vector4(0, a.y, 0, a.y); }
    public static Vector4 Swizzle_0y0z(this Vector4 a) { return new Vector4(0, a.y, 0, a.z); }
    public static Vector4 Swizzle_0y0w(this Vector4 a) { return new Vector4(0, a.y, 0, a.w); }
    public static Vector4 Swizzle_0y00(this Vector4 a) { return new Vector4(0, a.y, 0, 0); }
    public static Vector4 Swizzle_0y01(this Vector4 a) { return new Vector4(0, a.y, 0, 1); }
    public static Vector4 Swizzle_0y1x(this Vector4 a) { return new Vector4(0, a.y, 1, a.x); }
    public static Vector4 Swizzle_0y1y(this Vector4 a) { return new Vector4(0, a.y, 1, a.y); }
    public static Vector4 Swizzle_0y1z(this Vector4 a) { return new Vector4(0, a.y, 1, a.z); }
    public static Vector4 Swizzle_0y1w(this Vector4 a) { return new Vector4(0, a.y, 1, a.w); }
    public static Vector4 Swizzle_0y10(this Vector4 a) { return new Vector4(0, a.y, 1, 0); }
    public static Vector4 Swizzle_0y11(this Vector4 a) { return new Vector4(0, a.y, 1, 1); }
    public static Vector4 Swizzle_0zxx(this Vector4 a) { return new Vector4(0, a.z, a.x, a.x); }
    public static Vector4 Swizzle_0zxy(this Vector4 a) { return new Vector4(0, a.z, a.x, a.y); }
    public static Vector4 Swizzle_0zxz(this Vector4 a) { return new Vector4(0, a.z, a.x, a.z); }
    public static Vector4 Swizzle_0zxw(this Vector4 a) { return new Vector4(0, a.z, a.x, a.w); }
    public static Vector4 Swizzle_0zx0(this Vector4 a) { return new Vector4(0, a.z, a.x, 0); }
    public static Vector4 Swizzle_0zx1(this Vector4 a) { return new Vector4(0, a.z, a.x, 1); }
    public static Vector4 Swizzle_0zyx(this Vector4 a) { return new Vector4(0, a.z, a.y, a.x); }
    public static Vector4 Swizzle_0zyy(this Vector4 a) { return new Vector4(0, a.z, a.y, a.y); }
    public static Vector4 Swizzle_0zyz(this Vector4 a) { return new Vector4(0, a.z, a.y, a.z); }
    public static Vector4 Swizzle_0zyw(this Vector4 a) { return new Vector4(0, a.z, a.y, a.w); }
    public static Vector4 Swizzle_0zy0(this Vector4 a) { return new Vector4(0, a.z, a.y, 0); }
    public static Vector4 Swizzle_0zy1(this Vector4 a) { return new Vector4(0, a.z, a.y, 1); }
    public static Vector4 Swizzle_0zzx(this Vector4 a) { return new Vector4(0, a.z, a.z, a.x); }
    public static Vector4 Swizzle_0zzy(this Vector4 a) { return new Vector4(0, a.z, a.z, a.y); }
    public static Vector4 Swizzle_0zzz(this Vector4 a) { return new Vector4(0, a.z, a.z, a.z); }
    public static Vector4 Swizzle_0zzw(this Vector4 a) { return new Vector4(0, a.z, a.z, a.w); }
    public static Vector4 Swizzle_0zz0(this Vector4 a) { return new Vector4(0, a.z, a.z, 0); }
    public static Vector4 Swizzle_0zz1(this Vector4 a) { return new Vector4(0, a.z, a.z, 1); }
    public static Vector4 Swizzle_0zwx(this Vector4 a) { return new Vector4(0, a.z, a.w, a.x); }
    public static Vector4 Swizzle_0zwy(this Vector4 a) { return new Vector4(0, a.z, a.w, a.y); }
    public static Vector4 Swizzle_0zwz(this Vector4 a) { return new Vector4(0, a.z, a.w, a.z); }
    public static Vector4 Swizzle_0zww(this Vector4 a) { return new Vector4(0, a.z, a.w, a.w); }
    public static Vector4 Swizzle_0zw0(this Vector4 a) { return new Vector4(0, a.z, a.w, 0); }
    public static Vector4 Swizzle_0zw1(this Vector4 a) { return new Vector4(0, a.z, a.w, 1); }
    public static Vector4 Swizzle_0z0x(this Vector4 a) { return new Vector4(0, a.z, 0, a.x); }
    public static Vector4 Swizzle_0z0y(this Vector4 a) { return new Vector4(0, a.z, 0, a.y); }
    public static Vector4 Swizzle_0z0z(this Vector4 a) { return new Vector4(0, a.z, 0, a.z); }
    public static Vector4 Swizzle_0z0w(this Vector4 a) { return new Vector4(0, a.z, 0, a.w); }
    public static Vector4 Swizzle_0z00(this Vector4 a) { return new Vector4(0, a.z, 0, 0); }
    public static Vector4 Swizzle_0z01(this Vector4 a) { return new Vector4(0, a.z, 0, 1); }
    public static Vector4 Swizzle_0z1x(this Vector4 a) { return new Vector4(0, a.z, 1, a.x); }
    public static Vector4 Swizzle_0z1y(this Vector4 a) { return new Vector4(0, a.z, 1, a.y); }
    public static Vector4 Swizzle_0z1z(this Vector4 a) { return new Vector4(0, a.z, 1, a.z); }
    public static Vector4 Swizzle_0z1w(this Vector4 a) { return new Vector4(0, a.z, 1, a.w); }
    public static Vector4 Swizzle_0z10(this Vector4 a) { return new Vector4(0, a.z, 1, 0); }
    public static Vector4 Swizzle_0z11(this Vector4 a) { return new Vector4(0, a.z, 1, 1); }
    public static Vector4 Swizzle_0wxx(this Vector4 a) { return new Vector4(0, a.w, a.x, a.x); }
    public static Vector4 Swizzle_0wxy(this Vector4 a) { return new Vector4(0, a.w, a.x, a.y); }
    public static Vector4 Swizzle_0wxz(this Vector4 a) { return new Vector4(0, a.w, a.x, a.z); }
    public static Vector4 Swizzle_0wxw(this Vector4 a) { return new Vector4(0, a.w, a.x, a.w); }
    public static Vector4 Swizzle_0wx0(this Vector4 a) { return new Vector4(0, a.w, a.x, 0); }
    public static Vector4 Swizzle_0wx1(this Vector4 a) { return new Vector4(0, a.w, a.x, 1); }
    public static Vector4 Swizzle_0wyx(this Vector4 a) { return new Vector4(0, a.w, a.y, a.x); }
    public static Vector4 Swizzle_0wyy(this Vector4 a) { return new Vector4(0, a.w, a.y, a.y); }
    public static Vector4 Swizzle_0wyz(this Vector4 a) { return new Vector4(0, a.w, a.y, a.z); }
    public static Vector4 Swizzle_0wyw(this Vector4 a) { return new Vector4(0, a.w, a.y, a.w); }
    public static Vector4 Swizzle_0wy0(this Vector4 a) { return new Vector4(0, a.w, a.y, 0); }
    public static Vector4 Swizzle_0wy1(this Vector4 a) { return new Vector4(0, a.w, a.y, 1); }
    public static Vector4 Swizzle_0wzx(this Vector4 a) { return new Vector4(0, a.w, a.z, a.x); }
    public static Vector4 Swizzle_0wzy(this Vector4 a) { return new Vector4(0, a.w, a.z, a.y); }
    public static Vector4 Swizzle_0wzz(this Vector4 a) { return new Vector4(0, a.w, a.z, a.z); }
    public static Vector4 Swizzle_0wzw(this Vector4 a) { return new Vector4(0, a.w, a.z, a.w); }
    public static Vector4 Swizzle_0wz0(this Vector4 a) { return new Vector4(0, a.w, a.z, 0); }
    public static Vector4 Swizzle_0wz1(this Vector4 a) { return new Vector4(0, a.w, a.z, 1); }
    public static Vector4 Swizzle_0wwx(this Vector4 a) { return new Vector4(0, a.w, a.w, a.x); }
    public static Vector4 Swizzle_0wwy(this Vector4 a) { return new Vector4(0, a.w, a.w, a.y); }
    public static Vector4 Swizzle_0wwz(this Vector4 a) { return new Vector4(0, a.w, a.w, a.z); }
    public static Vector4 Swizzle_0www(this Vector4 a) { return new Vector4(0, a.w, a.w, a.w); }
    public static Vector4 Swizzle_0ww0(this Vector4 a) { return new Vector4(0, a.w, a.w, 0); }
    public static Vector4 Swizzle_0ww1(this Vector4 a) { return new Vector4(0, a.w, a.w, 1); }
    public static Vector4 Swizzle_0w0x(this Vector4 a) { return new Vector4(0, a.w, 0, a.x); }
    public static Vector4 Swizzle_0w0y(this Vector4 a) { return new Vector4(0, a.w, 0, a.y); }
    public static Vector4 Swizzle_0w0z(this Vector4 a) { return new Vector4(0, a.w, 0, a.z); }
    public static Vector4 Swizzle_0w0w(this Vector4 a) { return new Vector4(0, a.w, 0, a.w); }
    public static Vector4 Swizzle_0w00(this Vector4 a) { return new Vector4(0, a.w, 0, 0); }
    public static Vector4 Swizzle_0w01(this Vector4 a) { return new Vector4(0, a.w, 0, 1); }
    public static Vector4 Swizzle_0w1x(this Vector4 a) { return new Vector4(0, a.w, 1, a.x); }
    public static Vector4 Swizzle_0w1y(this Vector4 a) { return new Vector4(0, a.w, 1, a.y); }
    public static Vector4 Swizzle_0w1z(this Vector4 a) { return new Vector4(0, a.w, 1, a.z); }
    public static Vector4 Swizzle_0w1w(this Vector4 a) { return new Vector4(0, a.w, 1, a.w); }
    public static Vector4 Swizzle_0w10(this Vector4 a) { return new Vector4(0, a.w, 1, 0); }
    public static Vector4 Swizzle_0w11(this Vector4 a) { return new Vector4(0, a.w, 1, 1); }
    public static Vector4 Swizzle_00xx(this Vector4 a) { return new Vector4(0, 0, a.x, a.x); }
    public static Vector4 Swizzle_00xy(this Vector4 a) { return new Vector4(0, 0, a.x, a.y); }
    public static Vector4 Swizzle_00xz(this Vector4 a) { return new Vector4(0, 0, a.x, a.z); }
    public static Vector4 Swizzle_00xw(this Vector4 a) { return new Vector4(0, 0, a.x, a.w); }
    public static Vector4 Swizzle_00x0(this Vector4 a) { return new Vector4(0, 0, a.x, 0); }
    public static Vector4 Swizzle_00x1(this Vector4 a) { return new Vector4(0, 0, a.x, 1); }
    public static Vector4 Swizzle_00yx(this Vector4 a) { return new Vector4(0, 0, a.y, a.x); }
    public static Vector4 Swizzle_00yy(this Vector4 a) { return new Vector4(0, 0, a.y, a.y); }
    public static Vector4 Swizzle_00yz(this Vector4 a) { return new Vector4(0, 0, a.y, a.z); }
    public static Vector4 Swizzle_00yw(this Vector4 a) { return new Vector4(0, 0, a.y, a.w); }
    public static Vector4 Swizzle_00y0(this Vector4 a) { return new Vector4(0, 0, a.y, 0); }
    public static Vector4 Swizzle_00y1(this Vector4 a) { return new Vector4(0, 0, a.y, 1); }
    public static Vector4 Swizzle_00zx(this Vector4 a) { return new Vector4(0, 0, a.z, a.x); }
    public static Vector4 Swizzle_00zy(this Vector4 a) { return new Vector4(0, 0, a.z, a.y); }
    public static Vector4 Swizzle_00zz(this Vector4 a) { return new Vector4(0, 0, a.z, a.z); }
    public static Vector4 Swizzle_00zw(this Vector4 a) { return new Vector4(0, 0, a.z, a.w); }
    public static Vector4 Swizzle_00z0(this Vector4 a) { return new Vector4(0, 0, a.z, 0); }
    public static Vector4 Swizzle_00z1(this Vector4 a) { return new Vector4(0, 0, a.z, 1); }
    public static Vector4 Swizzle_00wx(this Vector4 a) { return new Vector4(0, 0, a.w, a.x); }
    public static Vector4 Swizzle_00wy(this Vector4 a) { return new Vector4(0, 0, a.w, a.y); }
    public static Vector4 Swizzle_00wz(this Vector4 a) { return new Vector4(0, 0, a.w, a.z); }
    public static Vector4 Swizzle_00ww(this Vector4 a) { return new Vector4(0, 0, a.w, a.w); }
    public static Vector4 Swizzle_00w0(this Vector4 a) { return new Vector4(0, 0, a.w, 0); }
    public static Vector4 Swizzle_00w1(this Vector4 a) { return new Vector4(0, 0, a.w, 1); }
    public static Vector4 Swizzle_000x(this Vector4 a) { return new Vector4(0, 0, 0, a.x); }
    public static Vector4 Swizzle_000y(this Vector4 a) { return new Vector4(0, 0, 0, a.y); }
    public static Vector4 Swizzle_000z(this Vector4 a) { return new Vector4(0, 0, 0, a.z); }
    public static Vector4 Swizzle_000w(this Vector4 a) { return new Vector4(0, 0, 0, a.w); }
    public static Vector4 Swizzle_0000(this Vector4 a) { return new Vector4(0, 0, 0, 0); }
    public static Vector4 Swizzle_0001(this Vector4 a) { return new Vector4(0, 0, 0, 1); }
    public static Vector4 Swizzle_001x(this Vector4 a) { return new Vector4(0, 0, 1, a.x); }
    public static Vector4 Swizzle_001y(this Vector4 a) { return new Vector4(0, 0, 1, a.y); }
    public static Vector4 Swizzle_001z(this Vector4 a) { return new Vector4(0, 0, 1, a.z); }
    public static Vector4 Swizzle_001w(this Vector4 a) { return new Vector4(0, 0, 1, a.w); }
    public static Vector4 Swizzle_0010(this Vector4 a) { return new Vector4(0, 0, 1, 0); }
    public static Vector4 Swizzle_0011(this Vector4 a) { return new Vector4(0, 0, 1, 1); }
    public static Vector4 Swizzle_01xx(this Vector4 a) { return new Vector4(0, 1, a.x, a.x); }
    public static Vector4 Swizzle_01xy(this Vector4 a) { return new Vector4(0, 1, a.x, a.y); }
    public static Vector4 Swizzle_01xz(this Vector4 a) { return new Vector4(0, 1, a.x, a.z); }
    public static Vector4 Swizzle_01xw(this Vector4 a) { return new Vector4(0, 1, a.x, a.w); }
    public static Vector4 Swizzle_01x0(this Vector4 a) { return new Vector4(0, 1, a.x, 0); }
    public static Vector4 Swizzle_01x1(this Vector4 a) { return new Vector4(0, 1, a.x, 1); }
    public static Vector4 Swizzle_01yx(this Vector4 a) { return new Vector4(0, 1, a.y, a.x); }
    public static Vector4 Swizzle_01yy(this Vector4 a) { return new Vector4(0, 1, a.y, a.y); }
    public static Vector4 Swizzle_01yz(this Vector4 a) { return new Vector4(0, 1, a.y, a.z); }
    public static Vector4 Swizzle_01yw(this Vector4 a) { return new Vector4(0, 1, a.y, a.w); }
    public static Vector4 Swizzle_01y0(this Vector4 a) { return new Vector4(0, 1, a.y, 0); }
    public static Vector4 Swizzle_01y1(this Vector4 a) { return new Vector4(0, 1, a.y, 1); }
    public static Vector4 Swizzle_01zx(this Vector4 a) { return new Vector4(0, 1, a.z, a.x); }
    public static Vector4 Swizzle_01zy(this Vector4 a) { return new Vector4(0, 1, a.z, a.y); }
    public static Vector4 Swizzle_01zz(this Vector4 a) { return new Vector4(0, 1, a.z, a.z); }
    public static Vector4 Swizzle_01zw(this Vector4 a) { return new Vector4(0, 1, a.z, a.w); }
    public static Vector4 Swizzle_01z0(this Vector4 a) { return new Vector4(0, 1, a.z, 0); }
    public static Vector4 Swizzle_01z1(this Vector4 a) { return new Vector4(0, 1, a.z, 1); }
    public static Vector4 Swizzle_01wx(this Vector4 a) { return new Vector4(0, 1, a.w, a.x); }
    public static Vector4 Swizzle_01wy(this Vector4 a) { return new Vector4(0, 1, a.w, a.y); }
    public static Vector4 Swizzle_01wz(this Vector4 a) { return new Vector4(0, 1, a.w, a.z); }
    public static Vector4 Swizzle_01ww(this Vector4 a) { return new Vector4(0, 1, a.w, a.w); }
    public static Vector4 Swizzle_01w0(this Vector4 a) { return new Vector4(0, 1, a.w, 0); }
    public static Vector4 Swizzle_01w1(this Vector4 a) { return new Vector4(0, 1, a.w, 1); }
    public static Vector4 Swizzle_010x(this Vector4 a) { return new Vector4(0, 1, 0, a.x); }
    public static Vector4 Swizzle_010y(this Vector4 a) { return new Vector4(0, 1, 0, a.y); }
    public static Vector4 Swizzle_010z(this Vector4 a) { return new Vector4(0, 1, 0, a.z); }
    public static Vector4 Swizzle_010w(this Vector4 a) { return new Vector4(0, 1, 0, a.w); }
    public static Vector4 Swizzle_0100(this Vector4 a) { return new Vector4(0, 1, 0, 0); }
    public static Vector4 Swizzle_0101(this Vector4 a) { return new Vector4(0, 1, 0, 1); }
    public static Vector4 Swizzle_011x(this Vector4 a) { return new Vector4(0, 1, 1, a.x); }
    public static Vector4 Swizzle_011y(this Vector4 a) { return new Vector4(0, 1, 1, a.y); }
    public static Vector4 Swizzle_011z(this Vector4 a) { return new Vector4(0, 1, 1, a.z); }
    public static Vector4 Swizzle_011w(this Vector4 a) { return new Vector4(0, 1, 1, a.w); }
    public static Vector4 Swizzle_0110(this Vector4 a) { return new Vector4(0, 1, 1, 0); }
    public static Vector4 Swizzle_0111(this Vector4 a) { return new Vector4(0, 1, 1, 1); }
    public static Vector4 Swizzle_1xxx(this Vector4 a) { return new Vector4(1, a.x, a.x, a.x); }
    public static Vector4 Swizzle_1xxy(this Vector4 a) { return new Vector4(1, a.x, a.x, a.y); }
    public static Vector4 Swizzle_1xxz(this Vector4 a) { return new Vector4(1, a.x, a.x, a.z); }
    public static Vector4 Swizzle_1xxw(this Vector4 a) { return new Vector4(1, a.x, a.x, a.w); }
    public static Vector4 Swizzle_1xx0(this Vector4 a) { return new Vector4(1, a.x, a.x, 0); }
    public static Vector4 Swizzle_1xx1(this Vector4 a) { return new Vector4(1, a.x, a.x, 1); }
    public static Vector4 Swizzle_1xyx(this Vector4 a) { return new Vector4(1, a.x, a.y, a.x); }
    public static Vector4 Swizzle_1xyy(this Vector4 a) { return new Vector4(1, a.x, a.y, a.y); }
    public static Vector4 Swizzle_1xyz(this Vector4 a) { return new Vector4(1, a.x, a.y, a.z); }
    public static Vector4 Swizzle_1xyw(this Vector4 a) { return new Vector4(1, a.x, a.y, a.w); }
    public static Vector4 Swizzle_1xy0(this Vector4 a) { return new Vector4(1, a.x, a.y, 0); }
    public static Vector4 Swizzle_1xy1(this Vector4 a) { return new Vector4(1, a.x, a.y, 1); }
    public static Vector4 Swizzle_1xzx(this Vector4 a) { return new Vector4(1, a.x, a.z, a.x); }
    public static Vector4 Swizzle_1xzy(this Vector4 a) { return new Vector4(1, a.x, a.z, a.y); }
    public static Vector4 Swizzle_1xzz(this Vector4 a) { return new Vector4(1, a.x, a.z, a.z); }
    public static Vector4 Swizzle_1xzw(this Vector4 a) { return new Vector4(1, a.x, a.z, a.w); }
    public static Vector4 Swizzle_1xz0(this Vector4 a) { return new Vector4(1, a.x, a.z, 0); }
    public static Vector4 Swizzle_1xz1(this Vector4 a) { return new Vector4(1, a.x, a.z, 1); }
    public static Vector4 Swizzle_1xwx(this Vector4 a) { return new Vector4(1, a.x, a.w, a.x); }
    public static Vector4 Swizzle_1xwy(this Vector4 a) { return new Vector4(1, a.x, a.w, a.y); }
    public static Vector4 Swizzle_1xwz(this Vector4 a) { return new Vector4(1, a.x, a.w, a.z); }
    public static Vector4 Swizzle_1xww(this Vector4 a) { return new Vector4(1, a.x, a.w, a.w); }
    public static Vector4 Swizzle_1xw0(this Vector4 a) { return new Vector4(1, a.x, a.w, 0); }
    public static Vector4 Swizzle_1xw1(this Vector4 a) { return new Vector4(1, a.x, a.w, 1); }
    public static Vector4 Swizzle_1x0x(this Vector4 a) { return new Vector4(1, a.x, 0, a.x); }
    public static Vector4 Swizzle_1x0y(this Vector4 a) { return new Vector4(1, a.x, 0, a.y); }
    public static Vector4 Swizzle_1x0z(this Vector4 a) { return new Vector4(1, a.x, 0, a.z); }
    public static Vector4 Swizzle_1x0w(this Vector4 a) { return new Vector4(1, a.x, 0, a.w); }
    public static Vector4 Swizzle_1x00(this Vector4 a) { return new Vector4(1, a.x, 0, 0); }
    public static Vector4 Swizzle_1x01(this Vector4 a) { return new Vector4(1, a.x, 0, 1); }
    public static Vector4 Swizzle_1x1x(this Vector4 a) { return new Vector4(1, a.x, 1, a.x); }
    public static Vector4 Swizzle_1x1y(this Vector4 a) { return new Vector4(1, a.x, 1, a.y); }
    public static Vector4 Swizzle_1x1z(this Vector4 a) { return new Vector4(1, a.x, 1, a.z); }
    public static Vector4 Swizzle_1x1w(this Vector4 a) { return new Vector4(1, a.x, 1, a.w); }
    public static Vector4 Swizzle_1x10(this Vector4 a) { return new Vector4(1, a.x, 1, 0); }
    public static Vector4 Swizzle_1x11(this Vector4 a) { return new Vector4(1, a.x, 1, 1); }
    public static Vector4 Swizzle_1yxx(this Vector4 a) { return new Vector4(1, a.y, a.x, a.x); }
    public static Vector4 Swizzle_1yxy(this Vector4 a) { return new Vector4(1, a.y, a.x, a.y); }
    public static Vector4 Swizzle_1yxz(this Vector4 a) { return new Vector4(1, a.y, a.x, a.z); }
    public static Vector4 Swizzle_1yxw(this Vector4 a) { return new Vector4(1, a.y, a.x, a.w); }
    public static Vector4 Swizzle_1yx0(this Vector4 a) { return new Vector4(1, a.y, a.x, 0); }
    public static Vector4 Swizzle_1yx1(this Vector4 a) { return new Vector4(1, a.y, a.x, 1); }
    public static Vector4 Swizzle_1yyx(this Vector4 a) { return new Vector4(1, a.y, a.y, a.x); }
    public static Vector4 Swizzle_1yyy(this Vector4 a) { return new Vector4(1, a.y, a.y, a.y); }
    public static Vector4 Swizzle_1yyz(this Vector4 a) { return new Vector4(1, a.y, a.y, a.z); }
    public static Vector4 Swizzle_1yyw(this Vector4 a) { return new Vector4(1, a.y, a.y, a.w); }
    public static Vector4 Swizzle_1yy0(this Vector4 a) { return new Vector4(1, a.y, a.y, 0); }
    public static Vector4 Swizzle_1yy1(this Vector4 a) { return new Vector4(1, a.y, a.y, 1); }
    public static Vector4 Swizzle_1yzx(this Vector4 a) { return new Vector4(1, a.y, a.z, a.x); }
    public static Vector4 Swizzle_1yzy(this Vector4 a) { return new Vector4(1, a.y, a.z, a.y); }
    public static Vector4 Swizzle_1yzz(this Vector4 a) { return new Vector4(1, a.y, a.z, a.z); }
    public static Vector4 Swizzle_1yzw(this Vector4 a) { return new Vector4(1, a.y, a.z, a.w); }
    public static Vector4 Swizzle_1yz0(this Vector4 a) { return new Vector4(1, a.y, a.z, 0); }
    public static Vector4 Swizzle_1yz1(this Vector4 a) { return new Vector4(1, a.y, a.z, 1); }
    public static Vector4 Swizzle_1ywx(this Vector4 a) { return new Vector4(1, a.y, a.w, a.x); }
    public static Vector4 Swizzle_1ywy(this Vector4 a) { return new Vector4(1, a.y, a.w, a.y); }
    public static Vector4 Swizzle_1ywz(this Vector4 a) { return new Vector4(1, a.y, a.w, a.z); }
    public static Vector4 Swizzle_1yww(this Vector4 a) { return new Vector4(1, a.y, a.w, a.w); }
    public static Vector4 Swizzle_1yw0(this Vector4 a) { return new Vector4(1, a.y, a.w, 0); }
    public static Vector4 Swizzle_1yw1(this Vector4 a) { return new Vector4(1, a.y, a.w, 1); }
    public static Vector4 Swizzle_1y0x(this Vector4 a) { return new Vector4(1, a.y, 0, a.x); }
    public static Vector4 Swizzle_1y0y(this Vector4 a) { return new Vector4(1, a.y, 0, a.y); }
    public static Vector4 Swizzle_1y0z(this Vector4 a) { return new Vector4(1, a.y, 0, a.z); }
    public static Vector4 Swizzle_1y0w(this Vector4 a) { return new Vector4(1, a.y, 0, a.w); }
    public static Vector4 Swizzle_1y00(this Vector4 a) { return new Vector4(1, a.y, 0, 0); }
    public static Vector4 Swizzle_1y01(this Vector4 a) { return new Vector4(1, a.y, 0, 1); }
    public static Vector4 Swizzle_1y1x(this Vector4 a) { return new Vector4(1, a.y, 1, a.x); }
    public static Vector4 Swizzle_1y1y(this Vector4 a) { return new Vector4(1, a.y, 1, a.y); }
    public static Vector4 Swizzle_1y1z(this Vector4 a) { return new Vector4(1, a.y, 1, a.z); }
    public static Vector4 Swizzle_1y1w(this Vector4 a) { return new Vector4(1, a.y, 1, a.w); }
    public static Vector4 Swizzle_1y10(this Vector4 a) { return new Vector4(1, a.y, 1, 0); }
    public static Vector4 Swizzle_1y11(this Vector4 a) { return new Vector4(1, a.y, 1, 1); }
    public static Vector4 Swizzle_1zxx(this Vector4 a) { return new Vector4(1, a.z, a.x, a.x); }
    public static Vector4 Swizzle_1zxy(this Vector4 a) { return new Vector4(1, a.z, a.x, a.y); }
    public static Vector4 Swizzle_1zxz(this Vector4 a) { return new Vector4(1, a.z, a.x, a.z); }
    public static Vector4 Swizzle_1zxw(this Vector4 a) { return new Vector4(1, a.z, a.x, a.w); }
    public static Vector4 Swizzle_1zx0(this Vector4 a) { return new Vector4(1, a.z, a.x, 0); }
    public static Vector4 Swizzle_1zx1(this Vector4 a) { return new Vector4(1, a.z, a.x, 1); }
    public static Vector4 Swizzle_1zyx(this Vector4 a) { return new Vector4(1, a.z, a.y, a.x); }
    public static Vector4 Swizzle_1zyy(this Vector4 a) { return new Vector4(1, a.z, a.y, a.y); }
    public static Vector4 Swizzle_1zyz(this Vector4 a) { return new Vector4(1, a.z, a.y, a.z); }
    public static Vector4 Swizzle_1zyw(this Vector4 a) { return new Vector4(1, a.z, a.y, a.w); }
    public static Vector4 Swizzle_1zy0(this Vector4 a) { return new Vector4(1, a.z, a.y, 0); }
    public static Vector4 Swizzle_1zy1(this Vector4 a) { return new Vector4(1, a.z, a.y, 1); }
    public static Vector4 Swizzle_1zzx(this Vector4 a) { return new Vector4(1, a.z, a.z, a.x); }
    public static Vector4 Swizzle_1zzy(this Vector4 a) { return new Vector4(1, a.z, a.z, a.y); }
    public static Vector4 Swizzle_1zzz(this Vector4 a) { return new Vector4(1, a.z, a.z, a.z); }
    public static Vector4 Swizzle_1zzw(this Vector4 a) { return new Vector4(1, a.z, a.z, a.w); }
    public static Vector4 Swizzle_1zz0(this Vector4 a) { return new Vector4(1, a.z, a.z, 0); }
    public static Vector4 Swizzle_1zz1(this Vector4 a) { return new Vector4(1, a.z, a.z, 1); }
    public static Vector4 Swizzle_1zwx(this Vector4 a) { return new Vector4(1, a.z, a.w, a.x); }
    public static Vector4 Swizzle_1zwy(this Vector4 a) { return new Vector4(1, a.z, a.w, a.y); }
    public static Vector4 Swizzle_1zwz(this Vector4 a) { return new Vector4(1, a.z, a.w, a.z); }
    public static Vector4 Swizzle_1zww(this Vector4 a) { return new Vector4(1, a.z, a.w, a.w); }
    public static Vector4 Swizzle_1zw0(this Vector4 a) { return new Vector4(1, a.z, a.w, 0); }
    public static Vector4 Swizzle_1zw1(this Vector4 a) { return new Vector4(1, a.z, a.w, 1); }
    public static Vector4 Swizzle_1z0x(this Vector4 a) { return new Vector4(1, a.z, 0, a.x); }
    public static Vector4 Swizzle_1z0y(this Vector4 a) { return new Vector4(1, a.z, 0, a.y); }
    public static Vector4 Swizzle_1z0z(this Vector4 a) { return new Vector4(1, a.z, 0, a.z); }
    public static Vector4 Swizzle_1z0w(this Vector4 a) { return new Vector4(1, a.z, 0, a.w); }
    public static Vector4 Swizzle_1z00(this Vector4 a) { return new Vector4(1, a.z, 0, 0); }
    public static Vector4 Swizzle_1z01(this Vector4 a) { return new Vector4(1, a.z, 0, 1); }
    public static Vector4 Swizzle_1z1x(this Vector4 a) { return new Vector4(1, a.z, 1, a.x); }
    public static Vector4 Swizzle_1z1y(this Vector4 a) { return new Vector4(1, a.z, 1, a.y); }
    public static Vector4 Swizzle_1z1z(this Vector4 a) { return new Vector4(1, a.z, 1, a.z); }
    public static Vector4 Swizzle_1z1w(this Vector4 a) { return new Vector4(1, a.z, 1, a.w); }
    public static Vector4 Swizzle_1z10(this Vector4 a) { return new Vector4(1, a.z, 1, 0); }
    public static Vector4 Swizzle_1z11(this Vector4 a) { return new Vector4(1, a.z, 1, 1); }
    public static Vector4 Swizzle_1wxx(this Vector4 a) { return new Vector4(1, a.w, a.x, a.x); }
    public static Vector4 Swizzle_1wxy(this Vector4 a) { return new Vector4(1, a.w, a.x, a.y); }
    public static Vector4 Swizzle_1wxz(this Vector4 a) { return new Vector4(1, a.w, a.x, a.z); }
    public static Vector4 Swizzle_1wxw(this Vector4 a) { return new Vector4(1, a.w, a.x, a.w); }
    public static Vector4 Swizzle_1wx0(this Vector4 a) { return new Vector4(1, a.w, a.x, 0); }
    public static Vector4 Swizzle_1wx1(this Vector4 a) { return new Vector4(1, a.w, a.x, 1); }
    public static Vector4 Swizzle_1wyx(this Vector4 a) { return new Vector4(1, a.w, a.y, a.x); }
    public static Vector4 Swizzle_1wyy(this Vector4 a) { return new Vector4(1, a.w, a.y, a.y); }
    public static Vector4 Swizzle_1wyz(this Vector4 a) { return new Vector4(1, a.w, a.y, a.z); }
    public static Vector4 Swizzle_1wyw(this Vector4 a) { return new Vector4(1, a.w, a.y, a.w); }
    public static Vector4 Swizzle_1wy0(this Vector4 a) { return new Vector4(1, a.w, a.y, 0); }
    public static Vector4 Swizzle_1wy1(this Vector4 a) { return new Vector4(1, a.w, a.y, 1); }
    public static Vector4 Swizzle_1wzx(this Vector4 a) { return new Vector4(1, a.w, a.z, a.x); }
    public static Vector4 Swizzle_1wzy(this Vector4 a) { return new Vector4(1, a.w, a.z, a.y); }
    public static Vector4 Swizzle_1wzz(this Vector4 a) { return new Vector4(1, a.w, a.z, a.z); }
    public static Vector4 Swizzle_1wzw(this Vector4 a) { return new Vector4(1, a.w, a.z, a.w); }
    public static Vector4 Swizzle_1wz0(this Vector4 a) { return new Vector4(1, a.w, a.z, 0); }
    public static Vector4 Swizzle_1wz1(this Vector4 a) { return new Vector4(1, a.w, a.z, 1); }
    public static Vector4 Swizzle_1wwx(this Vector4 a) { return new Vector4(1, a.w, a.w, a.x); }
    public static Vector4 Swizzle_1wwy(this Vector4 a) { return new Vector4(1, a.w, a.w, a.y); }
    public static Vector4 Swizzle_1wwz(this Vector4 a) { return new Vector4(1, a.w, a.w, a.z); }
    public static Vector4 Swizzle_1www(this Vector4 a) { return new Vector4(1, a.w, a.w, a.w); }
    public static Vector4 Swizzle_1ww0(this Vector4 a) { return new Vector4(1, a.w, a.w, 0); }
    public static Vector4 Swizzle_1ww1(this Vector4 a) { return new Vector4(1, a.w, a.w, 1); }
    public static Vector4 Swizzle_1w0x(this Vector4 a) { return new Vector4(1, a.w, 0, a.x); }
    public static Vector4 Swizzle_1w0y(this Vector4 a) { return new Vector4(1, a.w, 0, a.y); }
    public static Vector4 Swizzle_1w0z(this Vector4 a) { return new Vector4(1, a.w, 0, a.z); }
    public static Vector4 Swizzle_1w0w(this Vector4 a) { return new Vector4(1, a.w, 0, a.w); }
    public static Vector4 Swizzle_1w00(this Vector4 a) { return new Vector4(1, a.w, 0, 0); }
    public static Vector4 Swizzle_1w01(this Vector4 a) { return new Vector4(1, a.w, 0, 1); }
    public static Vector4 Swizzle_1w1x(this Vector4 a) { return new Vector4(1, a.w, 1, a.x); }
    public static Vector4 Swizzle_1w1y(this Vector4 a) { return new Vector4(1, a.w, 1, a.y); }
    public static Vector4 Swizzle_1w1z(this Vector4 a) { return new Vector4(1, a.w, 1, a.z); }
    public static Vector4 Swizzle_1w1w(this Vector4 a) { return new Vector4(1, a.w, 1, a.w); }
    public static Vector4 Swizzle_1w10(this Vector4 a) { return new Vector4(1, a.w, 1, 0); }
    public static Vector4 Swizzle_1w11(this Vector4 a) { return new Vector4(1, a.w, 1, 1); }
    public static Vector4 Swizzle_10xx(this Vector4 a) { return new Vector4(1, 0, a.x, a.x); }
    public static Vector4 Swizzle_10xy(this Vector4 a) { return new Vector4(1, 0, a.x, a.y); }
    public static Vector4 Swizzle_10xz(this Vector4 a) { return new Vector4(1, 0, a.x, a.z); }
    public static Vector4 Swizzle_10xw(this Vector4 a) { return new Vector4(1, 0, a.x, a.w); }
    public static Vector4 Swizzle_10x0(this Vector4 a) { return new Vector4(1, 0, a.x, 0); }
    public static Vector4 Swizzle_10x1(this Vector4 a) { return new Vector4(1, 0, a.x, 1); }
    public static Vector4 Swizzle_10yx(this Vector4 a) { return new Vector4(1, 0, a.y, a.x); }
    public static Vector4 Swizzle_10yy(this Vector4 a) { return new Vector4(1, 0, a.y, a.y); }
    public static Vector4 Swizzle_10yz(this Vector4 a) { return new Vector4(1, 0, a.y, a.z); }
    public static Vector4 Swizzle_10yw(this Vector4 a) { return new Vector4(1, 0, a.y, a.w); }
    public static Vector4 Swizzle_10y0(this Vector4 a) { return new Vector4(1, 0, a.y, 0); }
    public static Vector4 Swizzle_10y1(this Vector4 a) { return new Vector4(1, 0, a.y, 1); }
    public static Vector4 Swizzle_10zx(this Vector4 a) { return new Vector4(1, 0, a.z, a.x); }
    public static Vector4 Swizzle_10zy(this Vector4 a) { return new Vector4(1, 0, a.z, a.y); }
    public static Vector4 Swizzle_10zz(this Vector4 a) { return new Vector4(1, 0, a.z, a.z); }
    public static Vector4 Swizzle_10zw(this Vector4 a) { return new Vector4(1, 0, a.z, a.w); }
    public static Vector4 Swizzle_10z0(this Vector4 a) { return new Vector4(1, 0, a.z, 0); }
    public static Vector4 Swizzle_10z1(this Vector4 a) { return new Vector4(1, 0, a.z, 1); }
    public static Vector4 Swizzle_10wx(this Vector4 a) { return new Vector4(1, 0, a.w, a.x); }
    public static Vector4 Swizzle_10wy(this Vector4 a) { return new Vector4(1, 0, a.w, a.y); }
    public static Vector4 Swizzle_10wz(this Vector4 a) { return new Vector4(1, 0, a.w, a.z); }
    public static Vector4 Swizzle_10ww(this Vector4 a) { return new Vector4(1, 0, a.w, a.w); }
    public static Vector4 Swizzle_10w0(this Vector4 a) { return new Vector4(1, 0, a.w, 0); }
    public static Vector4 Swizzle_10w1(this Vector4 a) { return new Vector4(1, 0, a.w, 1); }
    public static Vector4 Swizzle_100x(this Vector4 a) { return new Vector4(1, 0, 0, a.x); }
    public static Vector4 Swizzle_100y(this Vector4 a) { return new Vector4(1, 0, 0, a.y); }
    public static Vector4 Swizzle_100z(this Vector4 a) { return new Vector4(1, 0, 0, a.z); }
    public static Vector4 Swizzle_100w(this Vector4 a) { return new Vector4(1, 0, 0, a.w); }
    public static Vector4 Swizzle_1000(this Vector4 a) { return new Vector4(1, 0, 0, 0); }
    public static Vector4 Swizzle_1001(this Vector4 a) { return new Vector4(1, 0, 0, 1); }
    public static Vector4 Swizzle_101x(this Vector4 a) { return new Vector4(1, 0, 1, a.x); }
    public static Vector4 Swizzle_101y(this Vector4 a) { return new Vector4(1, 0, 1, a.y); }
    public static Vector4 Swizzle_101z(this Vector4 a) { return new Vector4(1, 0, 1, a.z); }
    public static Vector4 Swizzle_101w(this Vector4 a) { return new Vector4(1, 0, 1, a.w); }
    public static Vector4 Swizzle_1010(this Vector4 a) { return new Vector4(1, 0, 1, 0); }
    public static Vector4 Swizzle_1011(this Vector4 a) { return new Vector4(1, 0, 1, 1); }
    public static Vector4 Swizzle_11xx(this Vector4 a) { return new Vector4(1, 1, a.x, a.x); }
    public static Vector4 Swizzle_11xy(this Vector4 a) { return new Vector4(1, 1, a.x, a.y); }
    public static Vector4 Swizzle_11xz(this Vector4 a) { return new Vector4(1, 1, a.x, a.z); }
    public static Vector4 Swizzle_11xw(this Vector4 a) { return new Vector4(1, 1, a.x, a.w); }
    public static Vector4 Swizzle_11x0(this Vector4 a) { return new Vector4(1, 1, a.x, 0); }
    public static Vector4 Swizzle_11x1(this Vector4 a) { return new Vector4(1, 1, a.x, 1); }
    public static Vector4 Swizzle_11yx(this Vector4 a) { return new Vector4(1, 1, a.y, a.x); }
    public static Vector4 Swizzle_11yy(this Vector4 a) { return new Vector4(1, 1, a.y, a.y); }
    public static Vector4 Swizzle_11yz(this Vector4 a) { return new Vector4(1, 1, a.y, a.z); }
    public static Vector4 Swizzle_11yw(this Vector4 a) { return new Vector4(1, 1, a.y, a.w); }
    public static Vector4 Swizzle_11y0(this Vector4 a) { return new Vector4(1, 1, a.y, 0); }
    public static Vector4 Swizzle_11y1(this Vector4 a) { return new Vector4(1, 1, a.y, 1); }
    public static Vector4 Swizzle_11zx(this Vector4 a) { return new Vector4(1, 1, a.z, a.x); }
    public static Vector4 Swizzle_11zy(this Vector4 a) { return new Vector4(1, 1, a.z, a.y); }
    public static Vector4 Swizzle_11zz(this Vector4 a) { return new Vector4(1, 1, a.z, a.z); }
    public static Vector4 Swizzle_11zw(this Vector4 a) { return new Vector4(1, 1, a.z, a.w); }
    public static Vector4 Swizzle_11z0(this Vector4 a) { return new Vector4(1, 1, a.z, 0); }
    public static Vector4 Swizzle_11z1(this Vector4 a) { return new Vector4(1, 1, a.z, 1); }
    public static Vector4 Swizzle_11wx(this Vector4 a) { return new Vector4(1, 1, a.w, a.x); }
    public static Vector4 Swizzle_11wy(this Vector4 a) { return new Vector4(1, 1, a.w, a.y); }
    public static Vector4 Swizzle_11wz(this Vector4 a) { return new Vector4(1, 1, a.w, a.z); }
    public static Vector4 Swizzle_11ww(this Vector4 a) { return new Vector4(1, 1, a.w, a.w); }
    public static Vector4 Swizzle_11w0(this Vector4 a) { return new Vector4(1, 1, a.w, 0); }
    public static Vector4 Swizzle_11w1(this Vector4 a) { return new Vector4(1, 1, a.w, 1); }
    public static Vector4 Swizzle_110x(this Vector4 a) { return new Vector4(1, 1, 0, a.x); }
    public static Vector4 Swizzle_110y(this Vector4 a) { return new Vector4(1, 1, 0, a.y); }
    public static Vector4 Swizzle_110z(this Vector4 a) { return new Vector4(1, 1, 0, a.z); }
    public static Vector4 Swizzle_110w(this Vector4 a) { return new Vector4(1, 1, 0, a.w); }
    public static Vector4 Swizzle_1100(this Vector4 a) { return new Vector4(1, 1, 0, 0); }
    public static Vector4 Swizzle_1101(this Vector4 a) { return new Vector4(1, 1, 0, 1); }
    public static Vector4 Swizzle_111x(this Vector4 a) { return new Vector4(1, 1, 1, a.x); }
    public static Vector4 Swizzle_111y(this Vector4 a) { return new Vector4(1, 1, 1, a.y); }
    public static Vector4 Swizzle_111z(this Vector4 a) { return new Vector4(1, 1, 1, a.z); }
    public static Vector4 Swizzle_111w(this Vector4 a) { return new Vector4(1, 1, 1, a.w); }
    public static Vector4 Swizzle_1110(this Vector4 a) { return new Vector4(1, 1, 1, 0); }
    public static Vector4 Swizzle_1111(this Vector4 a) { return new Vector4(1, 1, 1, 1); }
}
