﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteCodeFirst;

public class Meal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

