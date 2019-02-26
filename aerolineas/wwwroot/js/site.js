google.charts.load('current', { packages: ['corechart', 'bar'] });

google.charts.setOnLoadCallback(drawChart);

function drawChart() {

    var data1 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Proporción'],
        ['Hawaiian Airlines Inc.', 21.4],
        ['Republic Airlines ', 24.0],
        ['SkyWest Airlines Inc. ', 24.7],
        ['Spirit Air Lines', 25.44],
        ['Pinnacle Airlines Inc.', 25.56],
    ]);

    var data2 = google.visualization.arrayToDataTable([
        ['Nombre', 'Proporción', { role: 'style' }],
        ['SkyWest Airlines Inc.', 16.7, 'blue'],
        ['Alaska Airlines Inc.', 19.1, 'green'],
        ['Mesa Airlines Inc.', 19.9, 'gold'],
        ['Spirit Air Lines', 20.2, 'silver'],
        ['United Air Lines Inc.', 23.1, 'red'],
    ]);

    var data3 = google.visualization.arrayToDataTable([
        ['Nombre', 'Promedio', { role: 'style' }],
        ['Southwest Airlines Co.', 112684, 'blue'],
        ['Delta Air Lines Inc. ', 79749, 'green'],
        ['American Airlines Inc.', 76427, 'gold'],
        ['SkyWest Airlines Inc.', 64496, 'silver'],
        ['United Air Lines Inc.', 51821, 'red'],
    ]);

    var data4 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Cant. dest', { role: 'style' }],
        ['SkyWest Airlines Inc.', 265, 'blue'],
        ['ExpressJet Airlines Inc.', 172, 'green'],
        ['Envoy Air', 155, 'gold'],
        ['Delta Air Lines Inc.', 154, 'red'],
        ['Pinnacle Air Lines Inc.', 133, 'silver'],
    ])

    var data5A = google.visualization.arrayToDataTable([
        ['Nombre', 'Retraso/Dia', 'Vuelos/Dia'],
        ['Hawaiian Airlines Inc.', 5.93, 0.64],
        ['Virgin America', 9.62, 0.57],
        ['Alaska Airlines Inc.', 25.8, 1.51],
        ['Allegiant Air ', 51.0, 0.79],
        ['Spirit Air Lines', 51.9, 1.37],
    ]);

    var data6 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Cant. dest', { role: 'style' }],
        ['SkyWest Airlines Inc.', 16.7, 'blue'],
        ['Alaska Airlines Inc.', 19.1, 'green'],
        ['Mesa Airlines Inc.', 19.9, 'gold'],
        ['Spirit Air Lines', 20.2, 'red'],
        ['United Air Lines Inc.', 23.1, 'silver']
    ])

    var data7 = google.visualization.arrayToDataTable([
        ['Nombre', 'Proporción', { role: 'style' }],
        ['Alaska Airlines Inc.', 21.6, 'blue'],
        ['United Air Lines Inc.', 11.1, 'green'],
        ['Mesa Airlines Inc. ', 10.6, 'gold'],
        ['Allegiant Air ', 8.00, 'silver'],
        ['Envoy Air ', 7.9, 'red'],
    ]);

    var data8 = google.visualization.arrayToDataTable([
        ['Aerolínea', 'Distancia', { role: 'style' }],
        ['Delta Air lines Inc.', 4983, 'blue'],
        ['Hawaiian Airlines Inc.', 4983, 'green'],
        ['United Airlines Inc.', 4963, 'gold'],
        ['American Airlines Inc.', 3847, 'red'],
        ['Alaska Airlines Inc.', 2874, 'silver']
    ])

    var data9 = google.visualization.arrayToDataTable([
        ['Nombre', 'Cant. Vuelos', { role: 'style' }],
        ['Southwest Airlines Co.',11.33, 'blue'],
        ['American Airlines Inc.', 7.39, 'green'],
        ['Delta Air Lines Inc.',5.40, 'gold'],
        ['SkyWest Airlines Inc.', 5.14 , 'silver'],
        ['United Air Lines Inc.', 4.73 , 'red'],
    ]);

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
        pieSliceText: 'value',
        backgroundColor: { fill: 'transparent' }
    };

    var options2 = {
        title: 'Proporción de top 5 aerolíneas',
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Proporción', minValue: 0 },
        vAxis: { title: 'Aerolíneas' },
        backgroundColor: { fill: 'transparent' }
    };

    var options3 = {
        title: 'Promedio de vuelos mensuales',
        'width': '100%',
        'height': 285,
        pieSliceText: 'value',
        pieHole: 0.4,
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

    var options5A = {
        title: 'Promedio minutos de retraso y cantidad de vuelos.',
        hAxis: { title: 'Minutos de retraso / Cantidad de vuelos' },
        backgroundColor: { fill: 'transparent' }
    }

    var options6 = {
        title: 'Frecuencia vuelos - retraso por culpa propio de la aerolínea',
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Proporción', minValue: 0 },
        vAxis: { title: 'Aerolíneas' },
        backgroundColor: { fill: 'transparent' }
    }

    var options7 = {
        title: 'Proporción de aumento durante el 2018',
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

    var options9 = {
        title: 'Cantidad de vuelos al día',
        'width': '100%',
        'height': 285,
        chartArea: { width: '50%', height: '50%' },
        hAxis: { title: 'Cant. Vuelos', minValue: 0 },
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
    var chart3 = new google.visualization.PieChart(document.getElementById('chart3'));
    var chart4 = new google.visualization.ColumnChart(document.getElementById('chart4'));
    var chart5A = new google.charts.Bar(document.getElementById('chart5A'));
    var chart6 = new google.visualization.BarChart(document.getElementById('chart6'));
    var chart7 = new google.visualization.ColumnChart(document.getElementById('chart7'));
    var chart8 = new google.visualization.BarChart(document.getElementById('chart8'));
    var chart9 = new google.visualization.BarChart(document.getElementById('chart9'));
    var chart10 = new google.visualization.BarChart(document.getElementById('chart10'));

    //Se dibujan las graficas
    chart1.draw(data1, options1);
    chart2.draw(data2, options2);
    chart3.draw(data3, options3);
    chart4.draw(data4, options4);
    chart5A.draw(data5A, google.charts.Bar.convertOptions(options5A));
    chart6.draw(data6, options6);
    chart7.draw(data7, options7);
    chart8.draw(data8, options8);
    chart9.draw(data9, options9);
    chart10.draw(data10, options10);




}    