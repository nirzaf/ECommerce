﻿using System;
using System.Collections.Generic;
using Nop.Core.Domain.Messages;
using Nop.Core;

namespace Nop.Services.Messages
{
    /// <summary>
    /// ContactUs interface
    /// </summary>
    public partial interface IContactUsService
    {
        /// <summary>
        /// Deletes a contactus item
        /// </summary>
        /// <param name="contactus">ContactUs item</param>
        void DeleteContactUs(ContactUs contactus);

        /// <summary>
        /// Clears table
        /// </summary>
        void ClearTable();

        /// <summary>
        /// Gets all contactUs items
        /// </summary>
        /// <param name="fromUtc">ContactUs item creation from; null to load all records</param>
        /// <param name="toUtc">ContactUs item creation to; null to load all records</param>
        /// <param name="email">email</param>
        /// <param name="vendorId">vendorId; null to load all records</param>
        /// <param name="customerId">customerId; null to load all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns>ContactUs items</returns>
        IPagedList<ContactUs> GetAllContactUs(DateTime? fromUtc = null, DateTime? toUtc = null,
            string email = "", int vendorId = 0, int customerId = 0, int storeId = 0,
            int pageIndex = 0, int pageSize = int.MaxValue);

        /// <summary>
        /// Gets a contactus item
        /// </summary>
        /// <param name="contactUsId">ContactUs item identifier</param>
        /// <returns>ContactUs item</returns>
        ContactUs GetContactUsById(int contactUsId);

        /// <summary>
        /// Inserts a contactus item
        /// </summary>
        /// <param name="contactus">ContactUs</param>
        /// <returns>A contactus item</returns>
        void InsertContactUs(ContactUs contactus);

    }
}
