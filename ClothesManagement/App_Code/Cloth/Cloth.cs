using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Cloth 的摘要说明
/// </summary>
public class Cloth
{
    private string id;      //服装编号
    private string name;    //服装名称
    private string size;    //服装尺寸
    private string color;   //服装颜色
    private string pic;     //服装图片
    private int count;      //库存
    private int status;     //服装状态

    /// <summary>
    /// 空参构造
    /// </summary>
    public Cloth()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    /// <summary>
    /// 全参构造
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="size"></param>
    /// <param name="color"></param>
    /// <param name="pic"></param>
    /// <param name="count"></param>
    /// <param name="status"></param>
    public Cloth(string id, string name, string size, string color, string pic, int count, int status)
    {
        this.Id = id;
        this.Name = name;
        this.Size = size;
        this.Color = color;
        this.Pic = pic;
        this.Count = count;
        this.Status = status;
    }

    //getter setter 方法
    public string Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public string Size { get => size; set => size = value; }
    public string Color { get => color; set => color = value; }
    public string Pic { get => pic; set => pic = value; }
    public int Count { get => count; set => count = value; }
    public int Status { get => status; set => status = value; }
}