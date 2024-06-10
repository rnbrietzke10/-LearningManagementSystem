import Image from 'next/image';
import React from 'react';
import logoLight from '../../../public/logo-light.png';

const Navbar = () => {
  return (
    <nav className='flex sticky top-0 z-50 bg-white shadow-[0px_4.0px_4.0px_rgba(0,0,0,0.28)]'>
      <Image
        width={100}
        height={100}
        src={logoLight}
        alt='Mennta Edu Solutions'
      />
      <div></div>
    </nav>
  );
};

export default Navbar;
