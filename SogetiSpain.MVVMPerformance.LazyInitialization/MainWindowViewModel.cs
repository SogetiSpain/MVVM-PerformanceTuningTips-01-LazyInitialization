// ----------------------------------------------------------------------------
// <copyright file="MainWindowViewModel.cs" company="SOGETI Spain">
//     Copyright © 2017 SOGETI Spain. All rights reserved.
//     Powered by Óscar Fernández González a.k.a. Osc@rNET.
// </copyright>
// ----------------------------------------------------------------------------
namespace SogetiSpain.MVVMPerformance.LazyInitialization
{
    using System;

    using Prism.Mvvm;

    /// <summary>
    /// Represents the view model of the <see cref="MainWindow"/>.
    /// </summary>
    public sealed class MainWindowViewModel : BindableBase
    {
        #region Fields

        /// <summary>
        /// Defines the customer first name.
        /// </summary>
        private string _customerFirstName;

        /// <summary>
        /// Defines the customer last name.
        /// </summary>
        private string _customerLastName;

        /// <summary>
        /// Defines the model.
        /// </summary>
        private Lazy<Customer> _model = new Lazy<Customer>();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindowViewModel"/> class.
        /// </summary>
        public MainWindowViewModel()
        {
            _customerFirstName = "Sogeti Spain";
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the first name of the customer.
        /// </summary>
        /// <value>
        /// The first name of the customer.
        /// </value>
        public string CustomerFirstName
        {
            get
            {
                return _customerFirstName;
            }

            set
            {
                if (SetProperty(ref _customerFirstName, value))
                {
                    _model.Value.FirstName = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the last name of the customer.
        /// </summary>
        /// <value>
        /// The last name of the customer.
        /// </value>
        public string CustomerLastName
        {
            get
            {
                return _customerLastName;
            }

            set
            {
                if (SetProperty(ref _customerLastName, value))
                {
                    _model.Value.LastName = value;
                }
            }
        }

        #endregion Properties
    }
}