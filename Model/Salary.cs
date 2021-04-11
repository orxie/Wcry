using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Salary  
    {
       private int _itemId;

       public int ItemId  //工资发放批次编号（主键）
{
  get { return _itemId; }
  set { _itemId = value; }
}
       private int _userId; //员工编号（外键)

       public int UserId
       {
           get { return _userId; }
           set { _userId = value; }
       }
       private int _bonus;  //奖励金额

       public int Bonus
       {
           get { return _bonus; }
           set { _bonus = value; }
       }
       private int _forfeit;//惩罚金额

       public int Forfeit
       {
           get { return _forfeit; }
           set { _forfeit = value; }
       }
       private int _money; // 基本金额

public int Money
{
    get { return _money; }
    set { _money = value; }
}
private int _dough; //实发金额

public int Dough
{
    get { return _dough; }
    set { _dough = value; }
}
private int _state; //发放状态（0已发，1未发）

public int State
{
    get { return _state; }
    set { _state = value; }
}
private DateTime _time; //发放时间

public DateTime Time
{
    get { return _time; }
    set { _time = value; }
}
    }
}
