using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


namespace QuentameBlazor.Server.Repository
{
    public class NotifyBase : INotifyPropertyChanged //, INotifyDataErrorInfo
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        

        protected virtual void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #endregion

        //#region Notify Data Error

        //public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        //public void RaiseErrorsChanged(string propertyName)
        //{
        //    if (ErrorsChanged != null)
        //    {
        //        ErrorsChanged.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        //    }
        //}

        //public bool HasErrors
        //{
        //    get
        //    {
        //        return OnValidate(string.Empty).Count > 0;
        //    }
        //}

        //public IEnumerable GetErrors(string propertyName)
        //{
        //    return OnValidate(propertyName);
        //}

        //public bool IsValid
        //{
        //    get { return !this.HasErrors; }

        //}

        //private List<string> OnValidate(string columnName)
        //{
        //    List<string> result = new List<string>();

        //    if (!canValidateForErrors)
        //        return result;

        //    if (string.IsNullOrEmpty(columnName) || columnName == "RazonSocial")
        //    {
        //        if (string.IsNullOrEmpty(RazonSocial))
        //            result.Add("Ingrese Razón Social");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Nombre1")
        //    {
        //        if (string.IsNullOrEmpty(Nombre1))
        //            result.Add("Ingrese Primer Nombre");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Nombre2")
        //    {
        //        if (string.IsNullOrEmpty(Nombre2))
        //            result.Add("Ingrese Segundo Nombre");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Apellido1")
        //    {
        //        if (string.IsNullOrEmpty(Apellido1))
        //            result.Add("Ingrese Primer Apellido");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Apellido2")
        //    {
        //        if (string.IsNullOrEmpty(Apellido2))
        //            result.Add("Ingrese Segundo Apellido");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Telefono")
        //    {
        //        if (string.IsNullOrEmpty(Telefono))
        //            result.Add("Ingrese el número de teléfono");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Documento")
        //    {
        //        if (string.IsNullOrEmpty(Documento))
        //            result.Add("Ingrese número de documento");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Email")
        //    {
        //        if (!Regex.IsMatch(Email, mailPattern))
        //            result.Add("Ingrese un email válido");
        //    }

        //    if (string.IsNullOrEmpty(columnName) || columnName == "Direccion")
        //    {
        //        if (string.IsNullOrEmpty(Direccion))
        //            result.Add("Ingrese Dirección");
        //    }

        //    return result;
        //}

        //#endregion
    }
}
