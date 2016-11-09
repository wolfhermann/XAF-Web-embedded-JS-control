window.DxCode = window.DxCode || {};
window.DxCode.ChartControl = {
    createControl: function (panel) {
        var $mainElement = $(panel.GetMainElement());

        var uri = 'http://localhost:2064/api/chartdata/GetChartData?parentOid=' + panel.cpOid;
        $.getJSON(uri)
           .done(function (dataSource) {
               $mainElement.dxChart(
                   {
                       dataSource: dataSource,
                       commonSeriesSettings: {
                           argumentField: 'Argument',
                           valueField: 'Value'
                       },
                       series: [{
                           type: 'bar'
                       }]
                   }
                   );
           });
    }
};