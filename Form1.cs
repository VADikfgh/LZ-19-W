using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LZ_19_W
{
    public partial class Form1 : Form
    {
        // Клас для DataGridView (Дата та подія)
        public class EventRecord
        {
            public DateTime Date { get; set; }
            public string EventDescription { get; set; }
        }

        // Клас для точок (Відстань до початку координат)
        public class Point2D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double DistanceToOrigin => Math.Round(Math.Sqrt(X * X + Y * Y), 2);
        }

        // BindingList автоматично оновлює DataGridView при додаванні нових елементів
        private BindingList<EventRecord> eventsList;

        public Form1()
        {
            InitializeComponent();

            // Ініціалізація списку подій
            eventsList = new BindingList<EventRecord>();

            // Прив'язка списку до DataGridView
            dataGridView1.DataSource = eventsList;

            // Налаштування ширини колонок
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["EventDescription"].HeaderText = "Подія";
                dataGridView1.Columns["EventDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Прив'язка обробників подій до кнопок
            btnAddEvent.Click += BtnAddEvent_Click;
            btnCalculatePoints.Click += BtnCalculatePoints_Click;
        }

        // Завдання: Робота зі списком об'єктів у DataGridView
        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            string eventText = textBoxEvent.Text.Trim();

            if (string.IsNullOrEmpty(eventText))
            {
                MessageBox.Show("Будь ласка, введіть назву події.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Додавання нового об'єкта в список (DataGridView оновиться автоматично)
            eventsList.Add(new EventRecord
            {
                Date = dateTimePicker1.Value.Date,
                EventDescription = eventText
            });

            textBoxEvent.Clear();
        }

        // Завдання: Обчислити відстань між кожною точкою та початком координат
        private void BtnCalculatePoints_Click(object sender, EventArgs e)
        {
            List<Point2D> points = new List<Point2D>
            {
                new Point2D { X = 3, Y = 4 },   // Відстань = 5
                new Point2D { X = 0, Y = -10 }, // Відстань = 10
                new Point2D { X = 6, Y = 8 }    // Відстань = 10
            };

            string result = "Відстані точок до початку координат (0,0):\n\n";
            foreach (var point in points)
            {
                result += $"Точка ({point.X}, {point.Y}) -> Відстань: {point.DistanceToOrigin}\n";
            }

            MessageBox.Show(result, "Результат обчислення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}