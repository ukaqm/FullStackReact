import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5117/api/Bowling');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center"> List o' Bowlers </h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>BowlerID</th>
            <th>BowlerFirstName</th>
            <th>BowlerLastName</th>
            <th>BowlerCity</th>
            <th>BowlerState</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.BowlerId}>
              <td>{b.BowlerId}</td>
              <td>{b.BowlerFirstName}</td>
              <td>{b.BowlerLastName}</td>
              <td>{b.BowlerCity}</td>
              <td>{b.BowlerState}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
