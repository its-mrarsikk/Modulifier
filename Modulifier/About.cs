﻿using System.Reflection;

namespace Modulifier
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Text = String.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = "A GUI wrapper for different package managers (PIP, Node.js, etc.).";
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().Location);
            }
        }

#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
