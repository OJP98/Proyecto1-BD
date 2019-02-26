google.charts.load('current', { packages: ['corechart', 'bar'] });

google.charts.setOnLoadCallback(drawChart);

function drawChart() {

    var data1 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Porporción'],
        ['SkyWest Airlines Inc.', 16.7],
        ['Alaska Airlines Inc.', 19.1],
        ['Mesa Airlines Inc.', 19.9],
        ['Spirit Air Lines', 20.2],
        ['United Air Lines Inc.', 23.1],
    ]);

    var data2 = google.visualization.arrayToDataTable([
        ['Nombre', 'Porporción', { role: 'style' }],
        ['SkyWest Airlines Inc.', 16.7, 'blue'],
        ['Alaska Airlines Inc.', 19.1, 'green'],
        ['Mesa Airlines Inc.', 19.9, 'gold'],
        ['Spirit Air Lines', 20.2, 'silver'],
        ['United Air Lines Inc.', 23.1, 'red'],
    ]);

    var data4 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Cant. dest', { role: 'style' }],
        ['SkyWest Airlines Inc.', 265, 'blue'],
        ['ExpressJet Airlines Inc.', 172, 'green'],
        ['Envoy Air', 155, 'gold'],
        ['Delta Air Lines Inc.', 154, 'red'],
        ['Pinnacle Air Lines Inc.', 133, 'silver'],
    ])

    var data6 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Cant. dest', { role: 'style' }],
        ['SkyWest Airlines Inc.', 16.7, 'blue'],
        ['Alaska Airlines Inc.', 19.1, 'green'],
        ['Mesa Airlines Inc.', 19.9, 'gold'],
        ['Spirit Air Lines', 20.2, 'red'],
        ['United Air Lines Inc.', 23.1, 'silver']
    ])

    var data8 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Distancia', { role: 'style' }],
        ['Delta Air lines Inc.', 4983, 'blue'],
        ['Hawaiian Airlines Inc.', 4983, 'green'],
        ['United Airlines Inc.', 4963, 'gold'],
        ['American Airlines Inc.', 3847, 'red'],
        ['Alaska Airlines Inc.', 2874, 'silver']
    ])

    var data10 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Prom. 3 meses', { role: 'style' }],
        ['Southwest Airlines Co.', 111286, 'blue'],
        ['Midwest Airline, Inc.', 103948, 'green'],
        ['Delta Air Lines Inc.', 78813, 'gold'],
        ['American Airlines Inc.', 76218, 'red'],
        ['American Eagle Airlines Inc.', 75576, 'silver']
    ])


    var options1 = {
        title: 'Proporción de top 5 aerolíneas',
        'width': '100%',
        'height': 285,
        backgroundColor: { fill: 'transparent' }
    };

    var options2 = {
        title: 'Proporción de top 5 aerolíneas',
        'width': '100%',
        'height': 285,
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Proporción', minValue: 0 },
        vAxis: { title: 'Aerolíneas' },
        backgroundColor: { fill: 'transparent' }
    };

    var options4 = {
        title: 'Cantidad total de destinos',
        'width': '100%',
        'height': 285,
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Aerolíneas', minValue: 0 },
        vAxis: { title: 'Destinos' },
        backgroundColor: { fill: 'transparent' }
    }

    var options6 = {
        title: 'Frecuencia vuelos - retraso por culpa propio de la aerolínea',
        'width': '100%',
        'height': 285,
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Proporción', minValue: 0 },
        vAxis: { title: 'Aerolíneas' },
        backgroundColor: { fill: 'transparent' }
    }

    var options8 = {
        title: 'Distancia máxima recorrida por aerolínea',
        'width': '100%',
        'height': 285,
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Distancia', minValue: 0 },
        vAxis: { title: 'Aerolíneas' },
        backgroundColor: { fill: 'transparent' }
    }

    var options10 = {
        title: 'Actividad en los últimos 3 meses',
        'width': '100%',
        'height': 285,
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Prom. 3 meses', minValue: 0 },
        vAxis: { title: 'Aerolíneas' },
        backgroundColor: { fill: 'transparent' }
    }

    // Instantiate and draw our chart, passing in some options.
    var chart1 = new google.visualization.PieChart(document.getElementById('chart1'));
    var chart2 = new google.visualization.BarChart(document.getElementById('chart2'));
    var chart4 = new google.visualization.ColumnChart(document.getElementById('chart4'));
    var chart6 = new google.visualization.BarChart(document.getElementById('chart6'));
    var chart8 = new google.visualization.BarChart(document.getElementById('chart8'));
    var chart10 = new google.visualization.BarChart(document.getElementById('chart10'));

    //Se dibujan las graficas
    chart1.draw(data1, options1);
    chart2.draw(data2, options2);
    chart4.draw(data4, options4);
    chart6.draw(data6, options6);
    chart8.draw(data8, options8)
    chart10.draw(data10, options10)
}