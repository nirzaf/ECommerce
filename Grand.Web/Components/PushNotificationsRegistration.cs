using Grand.Core;
using Grand.Core.Domain.Customers;
using Grand.Core.Domain.PushNotifications;
using Grand.Framework.Components;
using Grand.Web.Models.PushNotifications;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Grand.Web.Components
{
    public class PushNotificationsRegistration : BaseViewComponent
    {
        private readonly PushNotificationsSettings _pushNotificationsSettings;
        private readonly IWorkContext _workContext;

        public PushNotificationsRegistration(PushNotificationsSettings pushNotificationsSettings, IWorkContext workContext)
        {
            _pushNotificationsSettings = pushNotificationsSettings;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model =
                await Task.Run(() =>
                {
                    var publicInfoModel = new PublicInfoModel();
                    publicInfoModel.PublicApiKey = _pushNotificationsSettings.PublicApiKey;
                    publicInfoModel.SenderId = _pushNotificationsSettings.SenderId;
                    publicInfoModel.AuthDomain = _pushNotificationsSettings.AuthDomain;
                    publicInfoModel.ProjectId = _pushNotificationsSettings.ProjectId;
                    publicInfoModel.StorageBucket = _pushNotificationsSettings.StorageBucket;
                    publicInfoModel.DatabaseUrl = _pushNotificationsSettings.DatabaseUrl;
                    return publicInfoModel;
                });
            if (_pushNotificationsSettings.Enabled)
            {
                if (!_pushNotificationsSettings.AllowGuestNotifications && _workContext.CurrentCustomer.IsGuest())
                    return Content("");

                return View(model);
            }

            return Content("");
        }
    }
}
