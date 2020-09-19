
$(document).ready(function () {
    var roefy14 = $("#ROE_FY14").val();
    var roefy15 = $("#ROE_FY15").val();

    var rwaFy14 = $("#rwafy14").val();
    var rvnFy14 = $("#revenuefy14").val()
    var rwaFy15 = $("#rwafy15").val();
    var rvnFy15 = $("#revenuefy15").val()
    initPieChart(roefy14,roefy15);
    initBarChart(rwaFy14,rvnFy14,rwaFy15,rvnFy15);
    initForm();

});

function initForm() {
    formatSepartor();
}

function formatSepartor() {
    var collection = $('.add-thspr');

    $.each(collection, function (index, value) {
        var num = $(this).val();
        var comma = /,/g;
        num = num.replace(comma, '');
        var numCommas = addCommas(num);
        $(this).val(numCommas);

        $(this).on("keyup", function (x) {
            var value = $(this).val();

            var comma = /,/g;
            value = value.replace(comma, '');
            var numCommas = addCommas(value);
            $(this).val(numCommas);

        });
    });

    
}

function onlyNumberKey(evt) {
    var ASCIICode = (evt.which) ? evt.which : evt.keyCode
    if (ASCIICode > 31 && (ASCIICode < 48 || ASCIICode > 57) && ASCIICode != 46) {
        return false;
    }
    return true;
}

function addCommas(nStr) {
    //console.log(nStr);
    nStr += '';
    var comma = /,/g;
    nStr = nStr.replace(comma, '');
    x = nStr.split('.');
    x1 = x[0];
    x2 = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(x1)) {
        x1 = x1.replace(rgx, '$1' + ',' + '$2');
    }
    return x1 + x2;
}

function initPieChart(fy14,fy15) {
    var canvas = document.getElementById("pieTes");
    var ctx = canvas.getContext('2d');

    var data = {
        labels: ["ROE FY14", "ROE FY15"],
        datasets: [{
            data: [fy14, fy15],
            backgroundColor: ["#34c38f", "#ebeff2"],
            hoverBackgroundColor: ["#34c38f", "#ebeff2"],
            hoverBorderColor: "#fff"
        }]
    };

    var options = {
        rotation: -0.7 * Math.PI
    };

    var myBarChart = new Chart(ctx, {
        type: 'pie',
        data: data,
        options: options
    });

}

function initBarChart(rwaFy14, rvnFy14, rwaFy15, rvnFy15) {
    var canvas = document.getElementById("barTes");
    var ctx = canvas.getContext('2d');

    var data = {
        labels: ["RWA FY14", "REVENUE FY14", "RWA FY15", "REVENUE FY15"],
        datasets: [{
            data: [rwaFy14, rvnFy14,rwaFy15,rvnFy15],
            backgroundColor: ["#34c38f", "#ebeff2"],
            hoverBackgroundColor: ["#34c38f", "#ebeff2"],
            hoverBorderColor: "#fff"
        }]
    };


    var options = {
        responsive: true,
        legend: {
            display: false
        }
    };


    var myBarChart = new Chart(ctx, {
        type: 'bar',
        data: data,
        options: options
    });
}



