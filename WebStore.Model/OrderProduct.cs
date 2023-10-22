﻿using System.ComponentModel.DataAnnotations;

namespace WebStore.Model;

public class OrderProduct
{
    [Key]
    public int Id { get; set; }
    public Order? Order { get; set; }
    public Product? Product { get; set; }
    public int Quantity { get; set; }
}