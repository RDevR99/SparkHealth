import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-side-menu",
  templateUrl: "./side-menu.component.html",
  styleUrls: ["./side-menu.component.scss"]
})
export class SideMenuComponent implements OnInit {
  generalRoutes = [
    { linkName: "Dashboard", url: "/dashboard", icon: "fas fa-columns fa-lg" },
    { linkName: "Tasks", url: "/tasks", icon: "fas fa-tasks fa-lg" },
    { linkName: "Reports", url: "/reports", icon: "fas fa-chart-area fa-lg" },
    {
      linkName: "Appointments",
      url: "/appointments",
      icon: "fas fa-calendar-alt fa-lg"
    },
    { linkName: "Timeline", url: "/timeline", icon: "fas fa-stream fa-lg" }
  ];

  managementRoutes = [
    { linkName: "Settings", url: "/account", icon: "fas fa-cog fa-lg" },
    { linkName: "Help", url: "/help", icon: "fas fa-info-circle fa-lg" },
    { linkName: "Feedback", url: "/feedback", icon: "fas fa-star fa-lg" },
    { linkName: "Signout", url: "/login", icon: "fas fa-sign-out-alt fa-lg" }
  ];

  constructor() {}

  ngOnInit() {}
}
