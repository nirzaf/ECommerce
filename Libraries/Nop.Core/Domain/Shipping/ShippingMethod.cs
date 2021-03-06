using System.Collections.Generic;
using Nop.Core.Domain.Directory;
using Nop.Core.Domain.Localization;

namespace Nop.Core.Domain.Shipping
{
    /// <summary>
    /// Represents a shipping method (used for offline shipping rate computation methods)
    /// </summary>
    public partial class ShippingMethod : BaseEntity, ILocalizedEntity
    {
        private ICollection<Country> _restrictedCountries;

        public ShippingMethod()
        {
            Locales = new List<LocalizedProperty>();
        }
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the collection of locales
        /// </summary>
        public IList<LocalizedProperty> Locales { get; set; }

        /// <summary>
        /// Gets or sets the restricted countries
        /// </summary>
        public virtual ICollection<Country> RestrictedCountries
        {
            get { return _restrictedCountries ?? (_restrictedCountries = new List<Country>()); }
            protected set { _restrictedCountries = value; }
        }
    }
}