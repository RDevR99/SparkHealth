import { Component, ViewChild, OnInit } from '@angular/core';
import { FullCalendarComponent } from '@fullcalendar/angular';
import dayGridPlugin from '@fullcalendar/daygrid';
import timeGrigPlugin from '@fullcalendar/timegrid';
import interactionPlugin from '@fullcalendar/interaction';
import { AppointmentService } from 'src/app/services';
import { IAppointment } from 'src/app/models';

@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.scss']
})
export class AppointmentsComponent {
  calendarEvents: IAppointment[];

  eventClicked = false;
  eventTitle = 'Empty Event';
  eventDescription = 'Empty Description';
  eventDoctorName = '';
  eventLocation = '';
  eventTime = '';
  eventBmi = 0;
  eventWeight = 0;

  constructor(private appointmentService: AppointmentService) {
    const organizationCode = 2;
    const patientId = 2756; // Ricky Perez
    this.appointmentService.getAppointmentsById(patientId, organizationCode)
      .then(result => this.calendarEvents = result).then(() => console.log(this.calendarEvents));
  }

  @ViewChild('calendar') calendarComponent: FullCalendarComponent;
  calendarPlugins = [
    dayGridPlugin,
    timeGrigPlugin,
    interactionPlugin
  ];

  handleDateClick(event) {
    this.eventClicked = true;
    this.eventTitle = event.event.title;
    this.eventDoctorName = event.event.extendedProps.doctorName;
    this.eventLocation = event.event.extendedProps.location;
    this.eventTime = event.event.start.toDateString();
    this.eventBmi = event.event.extendedProps.bmi;
    this.eventWeight = event.event.extendedProps.weight;

    if (event.event) {
      if (event.event.extendedProps.description.length !== 0) {
        this.eventDescription = event.event.extendedProps.description;
      } else {
        this.eventDescription = '';
      }
    }
  }
}
