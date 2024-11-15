namespace TestDI.Core
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

    public class CustomModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType == typeof(IService))
            {
                return new BinderTypeModelBinder(typeof(CustomModelBinder));
            }
            return null;
        }
    }

}