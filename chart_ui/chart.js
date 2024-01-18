// Include the Chart.js library

// Get the canvas element from the HTML file
const canvas = document.getElementById('myChart');

// Create the chart
const chart = new Chart(canvas, {
  type: 'line',
  data: {
    labels: [
      'January',
      'February',
      'March',
      'April',
      'May',
      'June',
      'July',
      'August',
      'September',
      'October',
      'November',
      'December',
    ],
    datasets: [
      {
        label: 'The number of rented-out properties by month',
        data: [100, 200, 150, 300, 250, 400, 350, 500, 450, 600, 550, 700],
        borderColor: 'blue',
        fill: false,
      },
    ],
  },
  options: {
    layout: {
      padding: 20,
    },
    responsive: true,
    scales: {
      y: {
        beginAtZero: true,
      },
    },
  },
});

// make a get request for the data
function getData() {
  fetch('http://localhost:3000/api/rentals')
    .then((response) => response.json())
    .then((data) => {
      console.log(data);
      const labels = data.map((item) => item.month);
      const dataValues = data.map((item) => item.count);
      chart.data.labels = labels;
      chart.data.datasets[0].data = dataValues;
      chart.update();
    });
}
