using FilterExample.Services;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterExample.Infrastructure {
    public class DiagnosticLoggerAttribute : Attribute, IFilterFactory {
        public bool IsReusable => true;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider) {
            TimeAverager averager = (TimeAverager)serviceProvider.GetService(typeof(TimeAverager));

            return new DiagnosticLoggerFilter(averager);
        }

        private class DiagnosticLoggerFilter : IAsyncResultFilter, IAsyncActionFilter {

            private readonly TimeAverager averager;
            private Stopwatch timer;

            public DiagnosticLoggerFilter(TimeAverager averager) {
                this.averager = averager;
            }

            public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next) {
                timer = Stopwatch.StartNew();

                await next();
            }

            public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next) {
                await next();
                timer.Stop();

                averager.addTime(timer.ElapsedMilliseconds);
            }
        }
    }
}
