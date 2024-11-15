namespace TestDI.Core
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class CustomModelBinder : IModelBinder
    {
        private readonly IServiceProvider _serviceProvider;

        public CustomModelBinder(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var parameterValue = bindingContext.ValueProvider.GetValue("type").FirstValue;

            IService service = parameterValue switch
            {
                "A" => _serviceProvider.GetService<ServiceA>(),
                "B" => _serviceProvider.GetService<ServiceB>(),
                _ => throw new InvalidOperationException("Invalid parameter value")
            };

            bindingContext.Result = ModelBindingResult.Success(service);
            return Task.CompletedTask;
        }
    }

}
