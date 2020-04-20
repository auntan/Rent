﻿using RentApi.Api.DTO;
using RentApi.Infrastructure.Database.Models;
using System.Linq;

namespace RentApi.Api.Extensions
{
    public static class RentExtensions
    {
        public static IQueryable<RentDTO> ToDTO(this IQueryable<Rent> rents)
        {
            return rents.Select(x => new RentDTO
            {
                Id = x.Id,
                Customer = x.Customer,
                ShopId = x.ShopId,
                EmployeeId = x.EmployeeId,
                From = x.From,
                To = x.To,
                Closed = x.Closed,
                Payment = x.Payment,
                Comment = x.Comment,
                EquipmentIds = x.RentEquipment.Select(x => x.EquipmentId).ToArray()
            });
        }

        public static IQueryable<EquipmentDTO> ToDTO(this IQueryable<Equipment> rents)
        {
            return rents.Select(x => new EquipmentDTO
            {
                Id = x.Id,
                Name = x.Name,
                ShopId = x.ShopId,
                EquipmentTypeId = x.EquipmentTypeId,
            });
        }
    }
}