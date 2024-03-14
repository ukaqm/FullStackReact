import './App.css';
import BowlerList from './Bowler/BowlerList';
import Header from './Header';

function App() {
  return (
    <div className="App">
      <Header title="First React/ASP.NET Application: Bowling League" />
      <BowlerList />
    </div>
  );
}

export default App;
