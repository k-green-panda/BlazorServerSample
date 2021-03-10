using BlazorServerSample.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace BlazorServerSample.Pages
{
    // デザインクラスと異なるクラス名で定義 / ComponentBase継承
    public class CodeBehindByBaseClassBase : ComponentBase
    {
        [Inject]
        public WeatherForecastService ForecastService { get; set; }

        // 子クラス(デザインクラス)から参照できるようアクセス修飾子を設定する
        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
