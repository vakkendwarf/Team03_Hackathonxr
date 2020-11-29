using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum t_Task : uint
{
    t_begin = 0,
    t_socks = t_begin + 1,
    t_underwear = t_begin + 2,
    t_tshirt = t_begin + 3,
    t_trash = t_begin + 4,
    t_books = t_begin + 5,
    t_teleport = t_begin + 6,
    t_dishes = t_begin + 7,
    t_end = t_dishes + 1
}