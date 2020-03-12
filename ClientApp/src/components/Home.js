import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>ToDoList</h1>
        <p>Welcome to my new single-page application</p>
        <input type="text"/>
        <ul class="tasksWrapper">
          <li>My task 1</li>
          <li>My task 2</li>
          <li>My task 3</li>
        </ul>
      </div>
    );
  }
}
