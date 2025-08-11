﻿using ModernWMS.Core.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ModernWMS.WMS.Entities.ViewModels
{
    public class DispatchlistDetailViewModel
    {
        #region constructor
        /// <summary>
        /// constructor
        /// </summary>
        public DispatchlistDetailViewModel()
        {

        }
        #endregion
        #region Property

        /// <summary>
        /// id
        /// </summary>
        [Display(Name = "id")]
        public int id { get; set; } = 0;

        /// <summary>
        /// dispatch_no
        /// </summary>
        [Display(Name = "dispatch_no")]
        [MaxLength(32, ErrorMessage = "MaxLength")]
        public string dispatch_no { get; set; } = string.Empty;

        /// <summary>
        /// dispatch_status
        /// </summary>
        [Display(Name = "dispatch_status")]
        public byte dispatch_status { get; set; } = 0;

        /// <summary>
        /// customer_id
        /// </summary>
        [Display(Name = "customer_id")]
        public int customer_id { get; set; } = 0;

        /// <summary>
        /// customer_name
        /// </summary>
        [Display(Name = "customer_name")]
        [MaxLength(256, ErrorMessage = "MaxLength")]
        public string customer_name { get; set; } = string.Empty;

        /// <summary>
        /// sku_id
        /// </summary>
        [Display(Name = "sku_id")]
        public int sku_id { get; set; } = 0;

        /// <summary>
        /// qty
        /// </summary>
        [Display(Name = "qty")]
        public int qty { get; set; } = 0;

        /// <summary>
        /// weight
        /// </summary>
        [Display(Name = "weight")]
        public decimal weight { get; set; } = 0;

        /// <summary>
        /// volume
        /// </summary>
        [Display(Name = "volume")]
        public decimal volume { get; set; } = 0;

        /// <summary>
        /// creator
        /// </summary>
        [Display(Name = "creator")]
        [MaxLength(64, ErrorMessage = "MaxLength")]
        public string creator { get; set; } = string.Empty;

        /// <summary>
        /// create_time
        /// </summary>
        [Display(Name = "create_time")]
        [DataType(DataType.DateTime, ErrorMessage = "DataType_DateTime")]
        public DateTime create_time { get; set; } = UtilConvert.MinDate;

        /// <summary>
        /// damage_qty
        /// </summary>
        [Display(Name = "damage_qty")]
        public int damage_qty { get; set; } = 0;

        /// <summary>
        /// lock_qty
        /// </summary>
        [Display(Name = "lock_qty")]
        public int lock_qty { get; set; } = 0;

        /// <summary>
        /// picked_qty
        /// </summary>
        [Display(Name = "picked_qty")]
        public int picked_qty { get; set; } = 0;

        /// <summary>
        /// intrasit_qty
        /// </summary>
        [Display(Name = "intrasit_qty")]
        public int intrasit_qty { get; set; } = 0;

        /// <summary>
        /// package_qty
        /// </summary>
        [Display(Name = "package_qty")]
        public int package_qty { get; set; } = 0;

        /// <summary>
        /// weighing_qty
        /// </summary>
        [Display(Name = "weighing_qty")]
        public int weighing_qty { get; set; } = 0;

        /// <summary>
        /// actual_qty
        /// </summary>
        [Display(Name = "actual_qty")]
        public int actual_qty { get; set; } = 0;

        /// <summary>
        /// sign_qty
        /// </summary>
        [Display(Name = "sign_qty")]
        public int sign_qty { get; set; } = 0;

        /// <summary>
        /// package_no
        /// </summary>
        [Display(Name = "package_no")]
        [MaxLength(32, ErrorMessage = "MaxLength")]
        public string package_no { get; set; } = string.Empty;

        /// <summary>
        /// package_person
        /// </summary>
        [Display(Name = "package_person")]
        [MaxLength(64, ErrorMessage = "MaxLength")]
        public string package_person { get; set; } = string.Empty;

        /// <summary>
        /// package_time
        /// </summary>
        [Display(Name = "package_time")]
        [DataType(DataType.DateTime, ErrorMessage = "DataType_DateTime")]
        public DateTime package_time { get; set; } = UtilConvert.MinDate;

        /// <summary>
        /// weighing_no
        /// </summary>
        [Display(Name = "weighing_no")]
        [MaxLength(32, ErrorMessage = "MaxLength")]
        public string weighing_no { get; set; } = string.Empty;

        /// <summary>
        /// weighing_person
        /// </summary>
        [Display(Name = "weighing_person")]
        [MaxLength(64, ErrorMessage = "MaxLength")]
        public string weighing_person { get; set; } = string.Empty;

        /// <summary>
        /// weighing_weight
        /// </summary>
        [Display(Name = "weighing_weight")]
        public decimal weighing_weight { get; set; } = 0;

        /// <summary>
        /// waybill_no
        /// </summary>
        [Display(Name = "waybill_no")]
        [MaxLength(64, ErrorMessage = "MaxLength")]
        public string waybill_no { get; set; } = string.Empty;

        /// <summary>
        /// carrier
        /// </summary>
        [Display(Name = "carrier")]
        [MaxLength(256, ErrorMessage = "MaxLength")]
        public string carrier { get; set; } = string.Empty;

        /// <summary>
        /// freightfee
        /// </summary>
        [Display(Name = "freightfee")]
        public decimal freightfee { get; set; } = 0;

        /// <summary>
        /// spu_code
        /// </summary>
        public string spu_code { get; set; } = string.Empty;

        /// <summary>
        /// spu_name
        /// </summary>
        public string spu_name { get; set; } = string.Empty;

        /// <summary>
        /// spu_description
        /// </summary>
        public string spu_description { get; set; } = string.Empty;

        /// <summary>
        /// bar_code
        /// </summary>
        public string bar_code { get; set; } = string.Empty;

        /// <summary>
        /// sku_code
        /// </summary>
        public string sku_code { get; set; } = string.Empty;


        /// <summary>
        /// pick_checker_id
        /// </summary>
        public decimal pick_checker_id { get; set; } = 0;

        /// <summary>
        /// pick_checker
        /// </summary>
        public string pick_checker { get; set; } = string.Empty;


        #endregion
    }
}
