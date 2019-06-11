using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Unity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.CodeDom;
using System.Configuration;
using System.Reflection;
using System.Threading.Tasks;
using CommonDTO.Common_Interfaces;
using Memory_Data_Storage;

namespace PhoneBook
{
    public class UnityConfig
    {
        #region Unity Container
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return Container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {

            container.RegisterType<IPhoneBookProvider, MemoryProvider>();

            UnityConfigurationSection unityConfig = null;
            try
            {
                unityConfig = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            }
            catch (Exception) {; }

            if (unityConfig != null && unityConfig.Containers?.Count > 0)
            {
                container.LoadConfiguration();
            }
        }
    }
    }