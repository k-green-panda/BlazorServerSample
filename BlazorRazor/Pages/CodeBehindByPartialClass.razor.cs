using BlazorRazor.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorRazor.Pages
{
    // 部分クラスとしてコードビハインドクラスを定義する
    public partial class CodeBehindByPartialClass
    {
        // サービスコンテナに登録したインスタンス受け取り(Inject属性)
        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
