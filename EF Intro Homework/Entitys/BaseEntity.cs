
using EF_Intro_Homework.Enums;
using System.ComponentModel.DataAnnotations;

namespace EF_Intro_Homework.Entitys;
public abstract class BaseEntity
{
    [Key]
    public int Id { get; set; }
    public Status Status { get; set; }
    public DateTime CreatedTime { get; set; }
    public DateTime ModifierTime { get; set; }


    public BaseEntity()
    {
        CreatedTime = DateTime.Now;
    }


}
